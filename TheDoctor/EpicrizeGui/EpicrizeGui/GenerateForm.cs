/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 16:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using EpicrizeGui.BusinessLogic;
using EpicrizeGui.Entity;
using WordDocumentBuilder;

namespace EpicrizeGui
{
	/// <summary>
	/// Description of GenerateForm.
	/// </summary>
	public partial class GenerateForm : Form
	{
		public GenerateForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.BindMatherChildList();				
		}
		
		private int ? matherId;
		private int ? childId;
		
		public GenerateForm(int ? childId)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			if(childId.HasValue)
			{
				var child = ChildBL.GetChild(childId.Value);
				this.childId = child.Id;
				this.matherId = child.MatherId;
				this.BindMatherChildList();
				this.BindChilds(child.MatherId);
			}
			else
			{
				this.BindMatherChildList();
			}
		}
		
		private void BindMatherChildList()
		{
			var list = MatherBL.GetMathers(this.tbSearchMather.Text);
			this.lvMather.View = View.List;
			var items = from mather in list
				select new ListViewItem() { Text = string.Format("{0} {1} {2}", mather.LastName, mather.FirstName, mather.MiddleName), Tag = mather.Id, Selected = this.matherId.HasValue && this.matherId.Value == mather.Id};			
			this.lvMather.Items.Clear();
			this.lvMather.Items.AddRange(items.ToArray());
		}
		
		private void BindChilds(int matherId)
		{			
			var list = ChildBL.GetChildrens(matherId);				
			var items = from child in list
				select new ListViewItem() { Text = string.Format("{0} {1} {2}", child.LastName, child.FirstName, child.MiddleName), Tag = child.Id, Selected = this.childId.HasValue && child.Id == this.childId.Value};
			this.lvChild.Items.Clear();
			this.lvChild.Items.AddRange(items.ToArray());
		}
		
		void LvMatherSelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.lvMather.SelectedItems.Count > 0)
			{
				this.BindChilds((int)this.lvMather.SelectedItems[0].Tag);
			}
			else
			{
				this.lvChild.Items.Clear();
			}
		}
		
		void BtnGenerateClick(object sender, EventArgs e)
		{
			if(this.lvChild.SelectedItems.Count > 0)
			{		
				WordDocumentManager manager = new WordDocumentManager(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["template"]));
				manager.Open();
				Department department = DepartmentBL.GetDepartment();
				Child child = ChildBL.GetChild((int)this.lvChild.SelectedItems[0].Tag);
				Mather mather = MatherBL.GetMather(child.MatherId);
				
				DocumentInsert.InsertEntity<Department>(manager.Document, department);
				DocumentInsert.InsertEntity<Child>(manager.Document, child);
				DocumentInsert.InsertEntity<Mather>(manager.Document, mather);
				
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				if(saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					manager.SaveAs(saveFileDialog.FileName);
				}
				
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
		
		void TbSearchMatherTextChanged(object sender, EventArgs e)
		{
			this.BindMatherChildList();
		}
	}
}
