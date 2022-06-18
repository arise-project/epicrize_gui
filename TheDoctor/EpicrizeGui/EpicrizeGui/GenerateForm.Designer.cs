/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 16:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EpicrizeGui
{
	partial class GenerateForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lvMather = new System.Windows.Forms.ListView();
			this.lvChild = new System.Windows.Forms.ListView();
			this.tbSearchMather = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Матері";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(231, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Діти";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(272, 266);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 2;
			this.btnGenerate.Text = "Створити";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.BtnGenerateClick);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(353, 266);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Відмінити";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lvMather
			// 
			this.lvMather.HideSelection = false;
			this.lvMather.Location = new System.Drawing.Point(12, 62);
			this.lvMather.Name = "lvMather";
			this.lvMather.Size = new System.Drawing.Size(213, 192);
			this.lvMather.TabIndex = 4;
			this.lvMather.UseCompatibleStateImageBehavior = false;
			this.lvMather.SelectedIndexChanged += new System.EventHandler(this.LvMatherSelectedIndexChanged);
			// 
			// lvChild
			// 
			this.lvChild.HideSelection = false;
			this.lvChild.Location = new System.Drawing.Point(231, 36);
			this.lvChild.Name = "lvChild";
			this.lvChild.Size = new System.Drawing.Size(197, 220);
			this.lvChild.TabIndex = 5;
			this.lvChild.UseCompatibleStateImageBehavior = false;
			this.lvChild.View = System.Windows.Forms.View.List;
			// 
			// tbSearchMather
			// 
			this.tbSearchMather.Location = new System.Drawing.Point(12, 36);
			this.tbSearchMather.Name = "tbSearchMather";
			this.tbSearchMather.Size = new System.Drawing.Size(213, 20);
			this.tbSearchMather.TabIndex = 6;
			this.tbSearchMather.TextChanged += new System.EventHandler(this.TbSearchMatherTextChanged);
			// 
			// GenerateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 301);
			this.Controls.Add(this.tbSearchMather);
			this.Controls.Add(this.lvChild);
			this.Controls.Add(this.lvMather);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "GenerateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Створити";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ListView lvMather;
		private System.Windows.Forms.ListView lvChild;
		private System.Windows.Forms.TextBox tbSearchMather;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
