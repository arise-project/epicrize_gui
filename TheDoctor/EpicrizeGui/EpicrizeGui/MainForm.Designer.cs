using System.Windows.Forms;
/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 14.01.2010
 * Time: 23:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EpicrizeGui
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.llDepartmentAddress = new System.Windows.Forms.LinkLabel();
			this.llDepartmentName = new System.Windows.Forms.LinkLabel();
			this.mtbIdentifier = new System.Windows.Forms.MaskedTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.rtbDepartmentAddress = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rtbDepartmentName = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.llMatherState = new System.Windows.Forms.LinkLabel();
			this.llCurrentHistory = new System.Windows.Forms.LinkLabel();
			this.llMatherAddress = new System.Windows.Forms.LinkLabel();
			this.btnNewMather = new System.Windows.Forms.Button();
			this.btnSaveMather = new System.Windows.Forms.Button();
			this.rtbMatherState = new System.Windows.Forms.RichTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.nudHoldDays = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.rtbCurrentHistory = new System.Windows.Forms.RichTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.nudBornCount = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.tbChildHistory = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.rtbMatherAddress = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.nudBornYear = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.tbMatherLastName = new System.Windows.Forms.TextBox();
			this.tbMatherMiddleName = new System.Windows.Forms.TextBox();
			this.tbMatherFirstName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbMatherSearch = new System.Windows.Forms.TextBox();
			this.lvMathers = new System.Windows.Forms.ListView();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.llOther = new System.Windows.Forms.LinkLabel();
			this.llRecomendation = new System.Windows.Forms.LinkLabel();
			this.llCurrentState = new System.Windows.Forms.LinkLabel();
			this.llHospitalState = new System.Windows.Forms.LinkLabel();
			this.btnNewChild = new System.Windows.Forms.Button();
			this.rtbOther = new System.Windows.Forms.RichTextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.rtbRecomendation = new System.Windows.Forms.RichTextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.tbBornHeight = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.tbCurrentWeight = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.tbBornWeight = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.rtbCurrentState = new System.Windows.Forms.RichTextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.rtbHospitalState = new System.Windows.Forms.RichTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.nudBornNumber = new System.Windows.Forms.NumericUpDown();
			this.label20 = new System.Windows.Forms.Label();
			this.nudOnMatherWeeks = new System.Windows.Forms.NumericUpDown();
			this.label19 = new System.Windows.Forms.Label();
			this.datetimepickerChildBornDate = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.tbChildLastName = new System.Windows.Forms.TextBox();
			this.tbChildMiddleName = new System.Windows.Forms.TextBox();
			this.tbChildFirstName = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.btnSaveChild = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.lvChildren = new System.Windows.Forms.ListView();
			this.tbMatherSearchChildren = new System.Windows.Forms.TextBox();
			this.lvMatherChildren = new System.Windows.Forms.ListView();
			this.toolStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudHoldDays)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBornCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBornYear)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBornNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudOnMatherWeeks)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(686, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(44, 22);
			this.toolStripButton1.Text = "Епікріз";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 25);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(686, 521);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.llDepartmentAddress);
			this.tabPage1.Controls.Add(this.llDepartmentName);
			this.tabPage1.Controls.Add(this.mtbIdentifier);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.rtbDepartmentAddress);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.rtbDepartmentName);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.ImageIndex = 0;
			this.tabPage1.Location = new System.Drawing.Point(167, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(515, 513);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Заголовок";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// llDepartmentAddress
			// 
			this.llDepartmentAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llDepartmentAddress.Location = new System.Drawing.Point(479, 275);
			this.llDepartmentAddress.Name = "llDepartmentAddress";
			this.llDepartmentAddress.Size = new System.Drawing.Size(28, 16);
			this.llDepartmentAddress.TabIndex = 9;
			this.llDepartmentAddress.TabStop = true;
			this.llDepartmentAddress.Text = ">>";
			// 
			// llDepartmentName
			// 
			this.llDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llDepartmentName.Location = new System.Drawing.Point(479, 142);
			this.llDepartmentName.Name = "llDepartmentName";
			this.llDepartmentName.Size = new System.Drawing.Size(28, 16);
			this.llDepartmentName.TabIndex = 8;
			this.llDepartmentName.TabStop = true;
			this.llDepartmentName.Text = ">>";
			// 
			// mtbIdentifier
			// 
			this.mtbIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mtbIdentifier.Location = new System.Drawing.Point(374, 294);
			this.mtbIdentifier.Name = "mtbIdentifier";
			this.mtbIdentifier.Size = new System.Drawing.Size(133, 20);
			this.mtbIdentifier.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(432, 482);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Зберегти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(172, 297);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ідентифікаційний код за ЄДРПОУ";
			// 
			// rtbDepartmentAddress
			// 
			this.rtbDepartmentAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDepartmentAddress.Location = new System.Drawing.Point(4, 181);
			this.rtbDepartmentAddress.Name = "rtbDepartmentAddress";
			this.rtbDepartmentAddress.Size = new System.Drawing.Size(504, 96);
			this.rtbDepartmentAddress.TabIndex = 3;
			this.rtbDepartmentAddress.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(292, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Найменування та повна адреса закладу";
			// 
			// rtbDepartmentName
			// 
			this.rtbDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDepartmentName.Location = new System.Drawing.Point(3, 43);
			this.rtbDepartmentName.Name = "rtbDepartmentName";
			this.rtbDepartmentName.Size = new System.Drawing.Size(504, 96);
			this.rtbDepartmentName.TabIndex = 1;
			this.rtbDepartmentName.Text = "";
			this.rtbDepartmentName.TextChanged += new System.EventHandler(this.RichTextBox1TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(507, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Назва міністерства, іншого центрального органу виконавчої влади, у сфері управлін" +
			"ня яких перебуває заклад";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.llMatherState);
			this.tabPage2.Controls.Add(this.llCurrentHistory);
			this.tabPage2.Controls.Add(this.llMatherAddress);
			this.tabPage2.Controls.Add(this.btnNewMather);
			this.tabPage2.Controls.Add(this.btnSaveMather);
			this.tabPage2.Controls.Add(this.rtbMatherState);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.nudHoldDays);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.rtbCurrentHistory);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.nudBornCount);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.tbChildHistory);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.rtbMatherAddress);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.nudBornYear);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.tbMatherLastName);
			this.tabPage2.Controls.Add(this.tbMatherMiddleName);
			this.tabPage2.Controls.Add(this.tbMatherFirstName);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.tbMatherSearch);
			this.tabPage2.Controls.Add(this.lvMathers);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.ImageIndex = 1;
			this.tabPage2.Location = new System.Drawing.Point(167, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(515, 513);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Мати";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// llMatherState
			// 
			this.llMatherState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llMatherState.Location = new System.Drawing.Point(484, 479);
			this.llMatherState.Name = "llMatherState";
			this.llMatherState.Size = new System.Drawing.Size(28, 16);
			this.llMatherState.TabIndex = 26;
			this.llMatherState.TabStop = true;
			this.llMatherState.Text = ">>";
			// 
			// llCurrentHistory
			// 
			this.llCurrentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llCurrentHistory.Location = new System.Drawing.Point(481, 327);
			this.llCurrentHistory.Name = "llCurrentHistory";
			this.llCurrentHistory.Size = new System.Drawing.Size(28, 16);
			this.llCurrentHistory.TabIndex = 25;
			this.llCurrentHistory.TabStop = true;
			this.llCurrentHistory.Text = ">>";
			// 
			// llMatherAddress
			// 
			this.llMatherAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llMatherAddress.Location = new System.Drawing.Point(481, 180);
			this.llMatherAddress.Name = "llMatherAddress";
			this.llMatherAddress.Size = new System.Drawing.Size(28, 16);
			this.llMatherAddress.TabIndex = 24;
			this.llMatherAddress.TabStop = true;
			this.llMatherAddress.Text = ">>";
			// 
			// btnNewMather
			// 
			this.btnNewMather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNewMather.Location = new System.Drawing.Point(7, 474);
			this.btnNewMather.Name = "btnNewMather";
			this.btnNewMather.Size = new System.Drawing.Size(75, 23);
			this.btnNewMather.TabIndex = 23;
			this.btnNewMather.Text = "Нова";
			this.btnNewMather.UseVisualStyleBackColor = true;
			this.btnNewMather.Click += new System.EventHandler(this.BtnNewMatherClick);
			// 
			// btnSaveMather
			// 
			this.btnSaveMather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveMather.Location = new System.Drawing.Point(88, 474);
			this.btnSaveMather.Name = "btnSaveMather";
			this.btnSaveMather.Size = new System.Drawing.Size(75, 23);
			this.btnSaveMather.TabIndex = 22;
			this.btnSaveMather.Text = "Зберігти";
			this.btnSaveMather.UseVisualStyleBackColor = true;
			this.btnSaveMather.Click += new System.EventHandler(this.BtnSaveMatherClick);
			// 
			// rtbMatherState
			// 
			this.rtbMatherState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbMatherState.Location = new System.Drawing.Point(200, 402);
			this.rtbMatherState.Name = "rtbMatherState";
			this.rtbMatherState.Size = new System.Drawing.Size(309, 95);
			this.rtbMatherState.TabIndex = 19;
			this.rtbMatherState.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(198, 376);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(284, 23);
			this.label12.TabIndex = 18;
			this.label12.Text = "Перебіг післяпологового періоду (захворювання) :";
			// 
			// nudHoldDays
			// 
			this.nudHoldDays.Location = new System.Drawing.Point(471, 346);
			this.nudHoldDays.Name = "nudHoldDays";
			this.nudHoldDays.Size = new System.Drawing.Size(38, 20);
			this.nudHoldDays.TabIndex = 21;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(197, 348);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(284, 23);
			this.label13.TabIndex = 20;
			this.label13.Text = "Виписана на день після пологів :";
			// 
			// rtbCurrentHistory
			// 
			this.rtbCurrentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbCurrentHistory.Location = new System.Drawing.Point(197, 283);
			this.rtbCurrentHistory.Name = "rtbCurrentHistory";
			this.rtbCurrentHistory.Size = new System.Drawing.Size(309, 57);
			this.rtbCurrentHistory.TabIndex = 17;
			this.rtbCurrentHistory.Text = "";
			this.rtbCurrentHistory.TextChanged += new System.EventHandler(this.RichTextBox4TextChanged);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(198, 266);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(284, 23);
			this.label11.TabIndex = 16;
			this.label11.Text = "Перебіг післяпологового періоду (захворювання) :";
			// 
			// nudBornCount
			// 
			this.nudBornCount.Location = new System.Drawing.Point(469, 199);
			this.nudBornCount.Name = "nudBornCount";
			this.nudBornCount.Size = new System.Drawing.Size(38, 20);
			this.nudBornCount.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(198, 196);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(285, 23);
			this.label10.TabIndex = 14;
			this.label10.Text = "Від якої вагітності за рахунком народилась дитина :";
			// 
			// tbChildHistory
			// 
			this.tbChildHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbChildHistory.Location = new System.Drawing.Point(408, 240);
			this.tbChildHistory.Name = "tbChildHistory";
			this.tbChildHistory.Size = new System.Drawing.Size(100, 20);
			this.tbChildHistory.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(198, 219);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(299, 47);
			this.label9.TabIndex = 12;
			this.label9.Text = "Попередні вагітності закінчилися: абортами, (штучними, самовільними)\nпологами, у " +
			"т.ч. з мертвим плодом.";
			// 
			// rtbMatherAddress
			// 
			this.rtbMatherAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbMatherAddress.Location = new System.Drawing.Point(198, 127);
			this.rtbMatherAddress.Name = "rtbMatherAddress";
			this.rtbMatherAddress.Size = new System.Drawing.Size(309, 66);
			this.rtbMatherAddress.TabIndex = 11;
			this.rtbMatherAddress.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(198, 109);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Адреса :";
			// 
			// nudBornYear
			// 
			this.nudBornYear.Location = new System.Drawing.Point(314, 84);
			this.nudBornYear.Name = "nudBornYear";
			this.nudBornYear.Size = new System.Drawing.Size(120, 20);
			this.nudBornYear.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(198, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Рік народження :";
			// 
			// tbMatherLastName
			// 
			this.tbMatherLastName.Location = new System.Drawing.Point(314, 56);
			this.tbMatherLastName.Name = "tbMatherLastName";
			this.tbMatherLastName.Size = new System.Drawing.Size(195, 20);
			this.tbMatherLastName.TabIndex = 7;
			// 
			// tbMatherMiddleName
			// 
			this.tbMatherMiddleName.Location = new System.Drawing.Point(314, 30);
			this.tbMatherMiddleName.Name = "tbMatherMiddleName";
			this.tbMatherMiddleName.Size = new System.Drawing.Size(195, 20);
			this.tbMatherMiddleName.TabIndex = 6;
			this.tbMatherMiddleName.TextChanged += new System.EventHandler(this.TbMatherMiddleNameTextChanged);
			// 
			// tbMatherFirstName
			// 
			this.tbMatherFirstName.Location = new System.Drawing.Point(314, 4);
			this.tbMatherFirstName.Name = "tbMatherFirstName";
			this.tbMatherFirstName.Size = new System.Drawing.Size(195, 20);
			this.tbMatherFirstName.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(198, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Призвище :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(198, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Побатькові :";
			// 
			// tbMatherSearch
			// 
			this.tbMatherSearch.Location = new System.Drawing.Point(7, 5);
			this.tbMatherSearch.Name = "tbMatherSearch";
			this.tbMatherSearch.Size = new System.Drawing.Size(185, 20);
			this.tbMatherSearch.TabIndex = 2;
			this.tbMatherSearch.TextChanged += new System.EventHandler(this.TbMatherSearchTextChanged);
			// 
			// lvMathers
			// 
			this.lvMathers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.lvMathers.HideSelection = false;
			this.lvMathers.Location = new System.Drawing.Point(6, 35);
			this.lvMathers.Name = "lvMathers";
			this.lvMathers.Size = new System.Drawing.Size(186, 433);
			this.lvMathers.TabIndex = 1;
			this.lvMathers.UseCompatibleStateImageBehavior = false;
			this.lvMathers.View = System.Windows.Forms.View.List;
			this.lvMathers.SelectedIndexChanged += new System.EventHandler(this.LvMathersSelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(198, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Ім\'я :";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.llOther);
			this.tabPage3.Controls.Add(this.llRecomendation);
			this.tabPage3.Controls.Add(this.llCurrentState);
			this.tabPage3.Controls.Add(this.llHospitalState);
			this.tabPage3.Controls.Add(this.btnNewChild);
			this.tabPage3.Controls.Add(this.rtbOther);
			this.tabPage3.Controls.Add(this.label27);
			this.tabPage3.Controls.Add(this.rtbRecomendation);
			this.tabPage3.Controls.Add(this.label26);
			this.tabPage3.Controls.Add(this.tbBornHeight);
			this.tabPage3.Controls.Add(this.label25);
			this.tabPage3.Controls.Add(this.tbCurrentWeight);
			this.tabPage3.Controls.Add(this.label24);
			this.tabPage3.Controls.Add(this.tbBornWeight);
			this.tabPage3.Controls.Add(this.label23);
			this.tabPage3.Controls.Add(this.rtbCurrentState);
			this.tabPage3.Controls.Add(this.label22);
			this.tabPage3.Controls.Add(this.rtbHospitalState);
			this.tabPage3.Controls.Add(this.label21);
			this.tabPage3.Controls.Add(this.nudBornNumber);
			this.tabPage3.Controls.Add(this.label20);
			this.tabPage3.Controls.Add(this.nudOnMatherWeeks);
			this.tabPage3.Controls.Add(this.label19);
			this.tabPage3.Controls.Add(this.datetimepickerChildBornDate);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.tbChildLastName);
			this.tabPage3.Controls.Add(this.tbChildMiddleName);
			this.tabPage3.Controls.Add(this.tbChildFirstName);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.label17);
			this.tabPage3.Controls.Add(this.label18);
			this.tabPage3.Controls.Add(this.btnSaveChild);
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.lvChildren);
			this.tabPage3.Controls.Add(this.tbMatherSearchChildren);
			this.tabPage3.Controls.Add(this.lvMatherChildren);
			this.tabPage3.ImageIndex = 2;
			this.tabPage3.Location = new System.Drawing.Point(167, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(515, 513);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Дитина";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// llOther
			// 
			this.llOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llOther.Location = new System.Drawing.Point(479, 501);
			this.llOther.Name = "llOther";
			this.llOther.Size = new System.Drawing.Size(28, 16);
			this.llOther.TabIndex = 40;
			this.llOther.TabStop = true;
			this.llOther.Text = ">>";
			// 
			// llRecomendation
			// 
			this.llRecomendation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llRecomendation.Location = new System.Drawing.Point(479, 460);
			this.llRecomendation.Name = "llRecomendation";
			this.llRecomendation.Size = new System.Drawing.Size(28, 16);
			this.llRecomendation.TabIndex = 39;
			this.llRecomendation.TabStop = true;
			this.llRecomendation.Text = ">>";
			// 
			// llCurrentState
			// 
			this.llCurrentState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llCurrentState.Location = new System.Drawing.Point(479, 296);
			this.llCurrentState.Name = "llCurrentState";
			this.llCurrentState.Size = new System.Drawing.Size(28, 16);
			this.llCurrentState.TabIndex = 38;
			this.llCurrentState.TabStop = true;
			this.llCurrentState.Text = ">>";
			// 
			// llHospitalState
			// 
			this.llHospitalState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llHospitalState.Location = new System.Drawing.Point(478, 232);
			this.llHospitalState.Name = "llHospitalState";
			this.llHospitalState.Size = new System.Drawing.Size(28, 16);
			this.llHospitalState.TabIndex = 37;
			this.llHospitalState.TabStop = true;
			this.llHospitalState.Text = ">>";
			// 
			// btnNewChild
			// 
			this.btnNewChild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNewChild.Location = new System.Drawing.Point(13, 480);
			this.btnNewChild.Name = "btnNewChild";
			this.btnNewChild.Size = new System.Drawing.Size(75, 23);
			this.btnNewChild.TabIndex = 36;
			this.btnNewChild.Text = "Нова";
			this.btnNewChild.UseVisualStyleBackColor = true;
			this.btnNewChild.Click += new System.EventHandler(this.BtnNewChildClick);
			// 
			// rtbOther
			// 
			this.rtbOther.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbOther.Location = new System.Drawing.Point(196, 482);
			this.rtbOther.Name = "rtbOther";
			this.rtbOther.Size = new System.Drawing.Size(311, 28);
			this.rtbOther.TabIndex = 35;
			this.rtbOther.Text = "";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(195, 469);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(297, 15);
			this.label27.TabIndex = 34;
			this.label27.Text = "Особливі зауваження :";
			// 
			// rtbRecomendation
			// 
			this.rtbRecomendation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbRecomendation.Location = new System.Drawing.Point(195, 413);
			this.rtbRecomendation.Name = "rtbRecomendation";
			this.rtbRecomendation.Size = new System.Drawing.Size(311, 53);
			this.rtbRecomendation.TabIndex = 33;
			this.rtbRecomendation.Text = "";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(195, 384);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(297, 36);
			this.label26.TabIndex = 32;
			this.label26.Text = "Чи потребує; млш патронаж: так, ні (підкреслити), показання :";
			// 
			// tbBornHeight
			// 
			this.tbBornHeight.Location = new System.Drawing.Point(357, 361);
			this.tbBornHeight.Name = "tbBornHeight";
			this.tbBornHeight.Size = new System.Drawing.Size(149, 20);
			this.tbBornHeight.TabIndex = 31;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(195, 364);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(172, 17);
			this.label25.TabIndex = 30;
			this.label25.Text = "Зріст дитини при народженні :";
			// 
			// tbCurrentWeight
			// 
			this.tbCurrentWeight.Location = new System.Drawing.Point(357, 338);
			this.tbCurrentWeight.Name = "tbCurrentWeight";
			this.tbCurrentWeight.Size = new System.Drawing.Size(149, 20);
			this.tbCurrentWeight.TabIndex = 29;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(195, 341);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(172, 17);
			this.label24.TabIndex = 28;
			this.label24.Text = "Вага дитини при виписці :";
			this.label24.Click += new System.EventHandler(this.Label24Click);
			// 
			// tbBornWeight
			// 
			this.tbBornWeight.Location = new System.Drawing.Point(357, 315);
			this.tbBornWeight.Name = "tbBornWeight";
			this.tbBornWeight.Size = new System.Drawing.Size(149, 20);
			this.tbBornWeight.TabIndex = 27;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(195, 318);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(172, 17);
			this.label23.TabIndex = 26;
			this.label23.Text = "Вага дитини при народженні :";
			// 
			// rtbCurrentState
			// 
			this.rtbCurrentState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbCurrentState.Location = new System.Drawing.Point(196, 252);
			this.rtbCurrentState.Name = "rtbCurrentState";
			this.rtbCurrentState.Size = new System.Drawing.Size(311, 53);
			this.rtbCurrentState.TabIndex = 25;
			this.rtbCurrentState.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(196, 235);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(172, 23);
			this.label22.TabIndex = 24;
			this.label22.Text = "Стан дитини при виписці:";
			// 
			// rtbHospitalState
			// 
			this.rtbHospitalState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbHospitalState.Location = new System.Drawing.Point(195, 176);
			this.rtbHospitalState.Name = "rtbHospitalState";
			this.rtbHospitalState.Size = new System.Drawing.Size(311, 53);
			this.rtbHospitalState.TabIndex = 23;
			this.rtbHospitalState.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(195, 159);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(172, 23);
			this.label21.TabIndex = 22;
			this.label21.Text = "Стан дитини при народженні:";
			// 
			// nudBornNumber
			// 
			this.nudBornNumber.Location = new System.Drawing.Point(458, 130);
			this.nudBornNumber.Name = "nudBornNumber";
			this.nudBornNumber.Size = new System.Drawing.Size(48, 20);
			this.nudBornNumber.TabIndex = 21;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(195, 127);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(236, 32);
			this.label20.TabIndex = 20;
			this.label20.Text = "При багароплідних пологах народилася  за рахунком :";
			// 
			// nudOnMatherWeeks
			// 
			this.nudOnMatherWeeks.Location = new System.Drawing.Point(422, 104);
			this.nudOnMatherWeeks.Name = "nudOnMatherWeeks";
			this.nudOnMatherWeeks.Size = new System.Drawing.Size(84, 20);
			this.nudOnMatherWeeks.TabIndex = 19;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(195, 106);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(236, 18);
			this.label19.TabIndex = 18;
			this.label19.Text = "Термін перебування в матері :";
			// 
			// datetimepickerChildBornDate
			// 
			this.datetimepickerChildBornDate.Location = new System.Drawing.Point(311, 81);
			this.datetimepickerChildBornDate.Name = "datetimepickerChildBornDate";
			this.datetimepickerChildBornDate.Size = new System.Drawing.Size(195, 20);
			this.datetimepickerChildBornDate.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(195, 83);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(113, 23);
			this.label14.TabIndex = 16;
			this.label14.Text = "Дата народження :";
			// 
			// tbChildLastName
			// 
			this.tbChildLastName.Location = new System.Drawing.Point(311, 55);
			this.tbChildLastName.Name = "tbChildLastName";
			this.tbChildLastName.Size = new System.Drawing.Size(195, 20);
			this.tbChildLastName.TabIndex = 15;
			// 
			// tbChildMiddleName
			// 
			this.tbChildMiddleName.Location = new System.Drawing.Point(311, 29);
			this.tbChildMiddleName.Name = "tbChildMiddleName";
			this.tbChildMiddleName.Size = new System.Drawing.Size(195, 20);
			this.tbChildMiddleName.TabIndex = 14;
			// 
			// tbChildFirstName
			// 
			this.tbChildFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbChildFirstName.Location = new System.Drawing.Point(311, 3);
			this.tbChildFirstName.Name = "tbChildFirstName";
			this.tbChildFirstName.Size = new System.Drawing.Size(195, 20);
			this.tbChildFirstName.TabIndex = 13;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(195, 58);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 23);
			this.label16.TabIndex = 12;
			this.label16.Text = "Призвище :";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(195, 29);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 11;
			this.label17.Text = "Побатькові :";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(195, 4);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 10;
			this.label18.Text = "Ім\'я :";
			// 
			// btnSaveChild
			// 
			this.btnSaveChild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveChild.Location = new System.Drawing.Point(94, 480);
			this.btnSaveChild.Name = "btnSaveChild";
			this.btnSaveChild.Size = new System.Drawing.Size(75, 23);
			this.btnSaveChild.TabIndex = 7;
			this.btnSaveChild.Text = "Зберігти";
			this.btnSaveChild.UseVisualStyleBackColor = true;
			this.btnSaveChild.Click += new System.EventHandler(this.BtnSaveChildClick);
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(4, 312);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 6;
			this.label15.Text = "Діти :";
			// 
			// lvChildren
			// 
			this.lvChildren.HideSelection = false;
			this.lvChildren.Location = new System.Drawing.Point(4, 338);
			this.lvChildren.Name = "lvChildren";
			this.lvChildren.Size = new System.Drawing.Size(186, 138);
			this.lvChildren.TabIndex = 5;
			this.lvChildren.UseCompatibleStateImageBehavior = false;
			this.lvChildren.View = System.Windows.Forms.View.List;
			this.lvChildren.SelectedIndexChanged += new System.EventHandler(this.LvChildrenSelectedIndexChanged);
			// 
			// tbMatherSearchChildren
			// 
			this.tbMatherSearchChildren.Location = new System.Drawing.Point(3, 3);
			this.tbMatherSearchChildren.Name = "tbMatherSearchChildren";
			this.tbMatherSearchChildren.Size = new System.Drawing.Size(185, 20);
			this.tbMatherSearchChildren.TabIndex = 4;
			this.tbMatherSearchChildren.TextChanged += new System.EventHandler(this.TbMatherSearchChildrenTextChanged);
			// 
			// lvMatherChildren
			// 
			this.lvMatherChildren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.lvMatherChildren.HideSelection = false;
			this.lvMatherChildren.Location = new System.Drawing.Point(2, 33);
			this.lvMatherChildren.Name = "lvMatherChildren";
			this.lvMatherChildren.Size = new System.Drawing.Size(186, 272);
			this.lvMatherChildren.TabIndex = 3;
			this.lvMatherChildren.UseCompatibleStateImageBehavior = false;
			this.lvMatherChildren.View = System.Windows.Forms.View.List;
			this.lvMatherChildren.SelectedIndexChanged += new System.EventHandler(this.LvMatherChildrenSelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 546);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolStrip1);
			this.MinimumSize = new System.Drawing.Size(640, 568);
			this.Name = "MainForm";
			this.Text = "EpicrizeGui";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudHoldDays)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBornCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBornYear)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBornNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudOnMatherWeeks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MaskedTextBox mtbIdentifier;
		private System.Windows.Forms.LinkLabel llCurrentState;
		private System.Windows.Forms.LinkLabel llRecomendation;
		private System.Windows.Forms.LinkLabel llOther;
		private System.Windows.Forms.LinkLabel llHospitalState;
		private System.Windows.Forms.LinkLabel llMatherAddress;
		private System.Windows.Forms.LinkLabel llCurrentHistory;
		private System.Windows.Forms.LinkLabel llMatherState;
		private System.Windows.Forms.LinkLabel llDepartmentName;
		private System.Windows.Forms.LinkLabel llDepartmentAddress;
		private System.Windows.Forms.DateTimePicker datetimepickerChildBornDate;
		private System.Windows.Forms.NumericUpDown nudOnMatherWeeks;
		private System.Windows.Forms.NumericUpDown nudBornNumber;
		private System.Windows.Forms.RichTextBox rtbHospitalState;
		private System.Windows.Forms.RichTextBox rtbCurrentState;
		private System.Windows.Forms.TextBox tbCurrentWeight;
		private System.Windows.Forms.TextBox tbBornWeight;
		private System.Windows.Forms.TextBox tbBornHeight;
		private System.Windows.Forms.RichTextBox rtbRecomendation;
		private System.Windows.Forms.RichTextBox rtbOther;
		private System.Windows.Forms.Button btnNewChild;
		private System.Windows.Forms.ListView lvChildren;
		private System.Windows.Forms.TextBox tbMatherSearchChildren;
		private System.Windows.Forms.ListView lvMatherChildren;
		private System.Windows.Forms.Button btnSaveChild;
		private System.Windows.Forms.TextBox tbChildLastName;
		private System.Windows.Forms.TextBox tbChildMiddleName;
		private System.Windows.Forms.TextBox tbChildFirstName;
		private System.Windows.Forms.TextBox tbMatherLastName;
		private System.Windows.Forms.TextBox tbMatherMiddleName;
		private System.Windows.Forms.TextBox tbMatherFirstName;
		private System.Windows.Forms.NumericUpDown nudBornYear;
		private System.Windows.Forms.RichTextBox rtbMatherAddress;
		private System.Windows.Forms.TextBox tbChildHistory;
		private System.Windows.Forms.NumericUpDown nudBornCount;
		private System.Windows.Forms.RichTextBox rtbCurrentHistory;
		private System.Windows.Forms.RichTextBox rtbMatherState;
		private System.Windows.Forms.NumericUpDown nudHoldDays;
		private System.Windows.Forms.Button btnSaveMather;
		private System.Windows.Forms.Button btnNewMather;
		private System.Windows.Forms.RichTextBox rtbDepartmentName;
		private System.Windows.Forms.RichTextBox rtbDepartmentAddress;
		private System.Windows.Forms.TextBox tbMatherSearch;
		private System.Windows.Forms.ListView lvMathers;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
