using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ImportBase
{
    public partial class Form1 : Form
    {
        SqlCeConnection connectSourse = null;
        SqlCeConnection connectDest = null;

        string[] _strTablesSourse;
        string[] _strTablesDest;
        string[,] _strTCSourse;
        string[,] _strTCDest;

        ArrayList all = new ArrayList();
        ArrayList dif = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectSourse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                tbSource.Text = openFileDialog1.FileName;
            }
        }

        private void btnSelectDestenation_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbDestenation.Text = openFileDialog1.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!OpenConnection()) return;
            GetMetadataToSring();

            progresBar.Value = 0;
            progresBar.Maximum = all.Count;
            progresBar.Visible = true;                       

            // перебираем таблицы по очереди
            for (int i = 0; i < all.Count; i++ )
            {
                // если текущая таблица уже скопирована - продолжаем цикл
                if (dif.IndexOf((string)all[i]) == -1)
                {
                    progresBar.Value++;
                    Application.DoEvents();
                    continue; 
                }
                else
                {
                    // ищем таблицу от которой зависит all[i] до тех пор, пока не скопируем all[i]
                    do
                    {
                        Application.DoEvents();
                        FindEndTable((string)all[i]);
                    } while (dif.IndexOf((string)all[i]) != -1);
                }
                Application.DoEvents();
                progresBar.Value++;
            }
            progresBar.Visible = false;
            LabelCurrrentTable.Text = "End copy data";
        }

        // по имени таблицы найти отцовские, если их нет, то скопировать таблицу
        private void FindEndTable(string table) 
        {            
            // получаем список отцовских таблиц
            ArrayList list_parent = FindNextTable(table);
            // если их нету
            if (list_parent.Count == 0)
            {
                // копируем table
                DoCopyData(table);
                // удаляем из списка таблиц
                dif.Remove(table);
                return;
            }
            else // есть зависимые таблицы
            {
                int flag = -1; // сколько отцовских таблиц не скопировано?
                for (int i = 0; i < list_parent.Count; i++) 
                {
                    if (dif.IndexOf((string)list_parent[i]) != -1) 
                    {
                        // запоминаем номер таблицы, которая отцовская над table и еще не скопированна - прерываем цикл - т.е. нашли первую не скопированную отцовскую таблицу
                        flag = i;
                        break;
                    }
                }
                if (flag == -1) // если все отцовские таблицы скопированы
                {
                    // копируем table
                    DoCopyData(table);
                    // удаляем из списка таблиц
                    dif.Remove(table);
                    return;
                }
                // иначе есть отцовская таблица, которая не скопированная - рекурсивно проверяем ее
                else FindEndTable((string)list_parent[flag]);
            }
        }

        // вернуть список отцовских таблиц над таблицей table
        ArrayList FindNextTable(string table) 
        {
            ArrayList ar = new ArrayList();
            string query = "SELECT T.F FROM " +
                            "(SELECT R.CONSTRAINT_TABLE_NAME AS \"D\", R.UNIQUE_CONSTRAINT_TABLE_NAME AS \"F\" " +
                             " FROM " +
                                " INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS R, " +
                                " INFORMATION_SCHEMA.KEY_COLUMN_USAGE U " +
                             " WHERE " +
                                " R.CONSTRAINT_NAME=U.CONSTRAINT_NAME) as T " +
                             "WHERE T.D=\'" + table + "\'";
            SqlCeCommand com = new SqlCeCommand(query, connectSourse);

            SqlCeDataReader rdr = com.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    ar.Add(rdr.GetString(0));
                }
            }
            finally 
            {
                rdr.Close();
            }

            return ar;
        }

        private void DoCopyData(string _tableName)
        {
            listBox1.Items.Add(_tableName);
            
            ArrayList _colTS = new ArrayList();
            ArrayList _colTD = new ArrayList();

            // начало формирования строки для запроса
            string queryInsert = "INSERT INTO [" + _tableName + "](";


            // вычисление необходимых данных для формирования типов данных параметров в строке запроса
            for (int i = 0; i < _strTCSourse.Length/3; i++)
            {
                if (_strTCSourse[i, 0].ToUpper() == _tableName.ToUpper()) 
                {
                    _colTS.Add(_strTCSourse[i, 1]);
                    _colTS.Add(_strTCSourse[i, 2]);
                }
            }
            for (int i = 0; i < _strTCDest.Length/3; i++)
            {
                if (_strTCDest[i, 0].ToUpper() == _tableName.ToUpper())
                {
                    _colTD.Add(_strTCDest[i, 1]);
                    _colTD.Add(_strTCDest[i, 2]);
                }
            }
            
            // формирование строки для запроса - запись полей и попутно параметров
            string tmpInsert = "";
            
            for (int i = 0, j = 0; i < _colTS.Count; i+=2, j++)
            {
                if (i == _colTS.Count - 2)
                    queryInsert += "[" + _colTS[i].ToString() + "]) VALUES(";
                else
                    queryInsert += "[" +_colTS[i].ToString() + "],";
                if (i == _colTS.Count - 2)
                    tmpInsert += "@parametr" + (j).ToString() + ")";
                else
                    tmpInsert += "@parametr" + (j).ToString() + ", ";
            }

            // окончательная строка сформированного запроса
            string tamplate = queryInsert + tmpInsert;

            // выборка данных с источника
            SqlCeCommand cmdSelectFromSourse = new SqlCeCommand("SELECT * FROM [" + _tableName + "]", connectSourse);
            
            // подготовка команды для вставки данных в таблицу-назначения
            SqlCeCommand commandInsert = new SqlCeCommand(tamplate, connectDest);

            // исходный параметр
            SqlCeParameter param = null;


            // в зависимости от типа данных таблицы источника
            for (int i = 0, j = 0; i < _colTS.Count; i += 2, j++)
            {
                // выбираем тип данных параметра и фигачим его команду
                // типы данных описал только те, что есть в базе данных
                switch (_colTS[i+1].ToString())
                {
                    case "int":
                        // к примеру тут формируем параметр типа int
                        param = new SqlCeParameter("@parametr" + (j).ToString(), SqlDbType.Int);
                        // добавляем в команду инсерта
                        commandInsert.Parameters.Add(param);
                        break;

                        // пробемы могут вылезти со строками - нужно отследить до конца все размерности в базе
                    case "nvarchar":
                        if (_tableName == "Group" && _colTS[i] == "Description") // например тут записано, что строка "ОПИСАНИЕ" в таблице ГРУППЫ может иметь длину 1000 символов
                            param = new SqlCeParameter("@parametr" + (j).ToString(), SqlDbType.NVarChar, 1000);
                        if (_tableName == "tmp")
                            param = new SqlCeParameter("@parametr" + (j).ToString(), SqlDbType.NVarChar, 100);
                        else // для всех nvarchar - ПОСТАВИЛ ПО УМОЛЧАНИЮ 50, НО НУЖНО ПРОВЕРИТЬ, КАК НА САМОМ ДЕЛЕ В БАЗЕ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
                            param = new SqlCeParameter("@parametr" + (j).ToString(), SqlDbType.NVarChar, 50);
                        commandInsert.Parameters.Add(param);
                        break;
                    case "datetime":
                        param = new SqlCeParameter("@parametr" + (j).ToString(), SqlDbType.DateTime);
                        commandInsert.Parameters.Add(param);
                        break;
                    case "bit":
                        param = new SqlCeParameter("@parametr" + (j).ToString(), SqlDbType.Bit);
                        commandInsert.Parameters.Add(param);
                        break;
                    case "ntext":
                        param = new SqlCeParameter("@parametr" + (j).ToString(), SqlDbType.NText);
                        commandInsert.Parameters.Add(param);
                        break;
                    case "float":
                        param = new SqlCeParameter("@parametr" + (j).ToString(), SqlDbType.Float);
                        commandInsert.Parameters.Add(param);
                        break;
                }

            }

            // создание ридера для прохода по записям. Ридер проходит по записям однонаправленно т.е. только один раз (зато быстро) - вернуться в начало нельзя.
            SqlCeDataReader rdr = cmdSelectFromSourse.ExecuteReader();

            // выключение у текущей таблицы (если оно есть) поля автоинкремента
            SetIdentity(connectDest, _tableName, "ON");

            // проход по записям
            while (rdr.Read())
            {
                // в соответствии со структурой записи в базе
                for (int i = 0; i < _colTS.Count / 2; i++)
                {
                    // формируем параметры
                    commandInsert.Parameters[i].Value = rdr.GetValue(i);
                }
                // ExecuteNonQuery - выполянет запросы на вставку, удаление, обновление
                commandInsert.ExecuteNonQuery();
            }

            // включение режима автоинкремента
            SetIdentity(connectDest, _tableName, "OFF");                        
        }

        private void SetIdentity(SqlCeConnection con, string _tablename, string _ONOFF) 
        {
            if (GetAutoIncColumn(_tablename, con) > 0)
            {
                SqlCeCommand com = new SqlCeCommand("SET IDENTITY_INSERT [" + _tablename + "] " + _ONOFF, con);
                com.ExecuteNonQuery();
            }
        }

        private int GetAutoIncColumn(string _tablename, SqlCeConnection con) 
        {
            int count = 0;
            string query = @"SELECT COUNT(AUTOINC_NEXT) AS Expr1
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE (TABLE_NAME = '" + _tablename + "')";
            SqlCeCommand com = new SqlCeCommand(query, con);
            count = (int)com.ExecuteScalar();
            return count;
        }

        private bool OpenConnection()
        {
            if (connectSourse == null)
            {
                connectSourse = new SqlCeConnection("Data Source=" + tbSource.Text);
                connectSourse.Open();
            }
            if (connectDest == null)
            {
                connectDest = new SqlCeConnection("Data Source=" + tbDestenation.Text);
                connectDest.Open();
            }
            if ((connectDest.State == ConnectionState.Open) && (connectSourse.State == ConnectionState.Open))
                return true;
            return false;
        }

        // выборка метаданных - названий (таблиц) и (таблиц и столбцов)
        private void GetMetadataToSring() 
        {
            // проверка - открыти ли подключения
            if (connectSourse.State == ConnectionState.Closed) return;
            if (connectDest.State == ConnectionState.Closed) return;

            string _strQueryTables = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            string _strQueryTColumns = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS";
            
            // выборка названий таблиц из источника и назначения
            SqlCeCommand _selectTablesSourse = new SqlCeCommand(_strQueryTables, connectSourse);
            SqlCeCommand _selectTablesDest = new SqlCeCommand(_strQueryTables, connectDest);

            SqlCeDataReader _readTablesSourse = _selectTablesSourse.ExecuteReader();
            SqlCeDataReader _readTablesDest = _selectTablesDest.ExecuteReader();

            _strTablesSourse = new string[GetCountRows(connectSourse, "INFORMATION_SCHEMA.TABLES")];
            _strTablesDest = new string[GetCountRows(connectDest, "INFORMATION_SCHEMA.TABLES")];

            try
            {
                int i = 0;
                while (_readTablesSourse.Read()) 
                {
                    all.Add(_readTablesSourse.GetString(0));
                    dif.Add(_readTablesSourse.GetString(0));
                    _strTablesSourse[i] = _readTablesSourse.GetString(0);
                    i++;
                }
                i = 0;
                while (_readTablesDest.Read()) 
                {
                    _strTablesDest[i] = _readTablesDest.GetString(0);
                    i++;
                }
            }
            finally
            {
                _readTablesSourse.Close();
                _readTablesDest.Close();
            }
            // end read tables

            // begin read tables and columns

            SqlCeCommand _selectTCSouse = new SqlCeCommand(_strQueryTColumns, connectSourse);
            SqlCeCommand _selectTCDest = new SqlCeCommand(_strQueryTColumns, connectDest);

            SqlCeDataReader _readTCSourse = _selectTCSouse.ExecuteReader();
            SqlCeDataReader _readTCDest = _selectTCDest.ExecuteReader();

            _strTCSourse = new string[GetCountRows(connectSourse, "INFORMATION_SCHEMA.COLUMNS"), 3];
            _strTCDest = new string[GetCountRows(connectDest, "INFORMATION_SCHEMA.COLUMNS"), 3];

            try
            {
                int i = 0;
                while (_readTCSourse.Read())
                {
                    _strTCSourse[i, 0] = _readTCSourse.GetString(0);
                    _strTCSourse[i, 1] = _readTCSourse.GetString(1);
                    _strTCSourse[i, 2] = _readTCSourse.GetString(2);
                    i++;
                }
                i = 0;
                while (_readTCDest.Read())
                {
                    _strTCDest[i, 0] = _readTCDest.GetString(0);
                    _strTCDest[i, 1] = _readTCDest.GetString(1);
                    _strTCDest[i, 2] = _readTCDest.GetString(2);                    
                    i++;
                }
            }
            finally 
            {
                _readTCSourse.Close();
                _readTCDest.Close();
            }
        }

        // Получение Кво строк в выборке
        private int GetCountRows(SqlCeConnection connection, string from) 
        {
            SqlCeCommand com = new SqlCeCommand("SELECT COUNT(*) FROM " + from, connection);
            int count = (int)com.ExecuteScalar();
            return count;
        }        

        // закрытие конекшенов при закрытии формы, если вдруг они были открыты
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connectDest.State == ConnectionState.Open) connectDest.Close();
            if (connectSourse.State == ConnectionState.Open) connectSourse.Close();
        }

        private void ClearTable(SqlCeConnection connection, string tableName)            
        {
            SqlCeCommand cmd = new SqlCeCommand("DELETE FROM [" + tableName + "]", connection);
            cmd.ExecuteNonQuery();
        }

        private void btnClearDataBase_Click(object sender, EventArgs e)
        {

        }


        // по этой кнопке в заранне заданном списке удаляются данные из таблиц (больше использовал для отладки)
        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnection();
            // таблицы введены в порядке убывания при копировании. Т.е. первая таблица, которую копировали - удаляется последней
            string[] tables = new string[] { "tmp", "SpecimenType", "SessionUser", "SessionChannel", "Run", "SessionRun", "Session", "GroupSpecimen", "Specimen", "Group", "Users", "Experiment", "Config" };
            foreach (string s in tables) 
            {
                ClearTable(connectDest, s);
            }
        }
    }
}
