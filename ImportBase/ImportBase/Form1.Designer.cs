namespace ImportBase
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.btnSelectSourse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestenation = new System.Windows.Forms.TextBox();
            this.btnSelectDestenation = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progresBar = new System.Windows.Forms.ToolStripProgressBar();
            this.LabelCurrrentTable = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sourse:";
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(88, 9);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(292, 20);
            this.tbSource.TabIndex = 1;
            // 
            // btnSelectSourse
            // 
            this.btnSelectSourse.Location = new System.Drawing.Point(386, 7);
            this.btnSelectSourse.Name = "btnSelectSourse";
            this.btnSelectSourse.Size = new System.Drawing.Size(44, 23);
            this.btnSelectSourse.TabIndex = 2;
            this.btnSelectSourse.Text = "...";
            this.btnSelectSourse.UseVisualStyleBackColor = true;
            this.btnSelectSourse.Click += new System.EventHandler(this.btnSelectSourse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "sdf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Data files (*.sdf)|*.sdf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destenation:";
            // 
            // tbDestenation
            // 
            this.tbDestenation.Location = new System.Drawing.Point(88, 34);
            this.tbDestenation.Name = "tbDestenation";
            this.tbDestenation.Size = new System.Drawing.Size(292, 20);
            this.tbDestenation.TabIndex = 4;
            // 
            // btnSelectDestenation
            // 
            this.btnSelectDestenation.Location = new System.Drawing.Point(386, 32);
            this.btnSelectDestenation.Name = "btnSelectDestenation";
            this.btnSelectDestenation.Size = new System.Drawing.Size(44, 23);
            this.btnSelectDestenation.TabIndex = 5;
            this.btnSelectDestenation.Text = "...";
            this.btnSelectDestenation.UseVisualStyleBackColor = true;
            this.btnSelectDestenation.Click += new System.EventHandler(this.btnSelectDestenation_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progresBar,
            this.LabelCurrrentTable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(444, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progresBar
            // 
            this.progresBar.Name = "progresBar";
            this.progresBar.Size = new System.Drawing.Size(150, 16);
            this.progresBar.Visible = false;
            // 
            // LabelCurrrentTable
            // 
            this.LabelCurrrentTable.Name = "LabelCurrrentTable";
            this.LabelCurrrentTable.Size = new System.Drawing.Size(16, 17);
            this.LabelCurrrentTable.Text = "...";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 34);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start copy";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(18, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete DB tables data from Dest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(158, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(272, 199);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 310);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSelectDestenation);
            this.Controls.Add(this.tbDestenation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectSourse);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Import DataBase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Button btnSelectSourse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestenation;
        private System.Windows.Forms.Button btnSelectDestenation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progresBar;
        private System.Windows.Forms.ToolStripStatusLabel LabelCurrrentTable;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

