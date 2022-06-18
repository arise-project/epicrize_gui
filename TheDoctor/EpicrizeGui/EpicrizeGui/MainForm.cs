/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 14.01.2010
 * Time: 23:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using EpicrizeGui.BusinessLogic;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EpicrizeGui.Entity;

namespace EpicrizeGui
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.tbChildMiddleName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			this.tbChildFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			this.tbChildLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			this.tbMatherLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			this.tbMatherMiddleName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			this.tbMatherFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
		}
		
		
		void Label24Click(object sender, EventArgs e)
		{
			
		}
		
		void RichTextBox4TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			GenerateForm form = new GenerateForm(this.childId);			
			form.ShowDialog();
		}
		
		void TbMatherMiddleNameTextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		private void BindDepartment()
		{
			Department department = DepartmentBL.GetDepartment();
			this.rtbDepartmentName.Text = department.DepartmentName;
			this.rtbDepartmentAddress.Text = department.DepartmentAddress;
			this.mtbIdentifier.Text = department.Identifier;
			//this.tb
		}
		
		private void SaveDepartment()
		{
			Department department = new Department();
			department.DepartmentName = this.rtbDepartmentName.Text;
			department.DepartmentAddress = this.rtbDepartmentAddress.Text;
			department.Identifier = this.mtbIdentifier.Text;
			
			DepartmentBL.SaveDepartment(department);
		}
		
		private void BindMatherList()
		{
			var list = MatherBL.GetMathers(this.tbMatherSearch.Text);		
			var items = from mather in list
				select new ListViewItem() { Text = string.Format("{0} {1} {2}", mather.LastName, mather.FirstName, mather.MiddleName), Tag = mather.Id, Selected = this.matherId.HasValue && mather.Id == this.matherId.Value};
			this.lvMathers.Items.Clear();
			this.lvMathers.Items.AddRange(items.ToArray());			
		}
		
		private void BindMatherChildList()
		{
			var list = MatherBL.GetMathers(this.tbMatherSearchChildren.Text);
			this.lvMathers.View = View.List;
			var items = from mather in list
				select new ListViewItem() { Text = string.Format("{0} {1} {2}", mather.LastName, mather.FirstName, mather.MiddleName), Tag = mather.Id};			
			this.lvMatherChildren.Items.Clear();
			this.lvMatherChildren.Items.AddRange(items.ToArray());
		}
		
		private void BindChilds(int matherId)
		{
			var list = ChildBL.GetChildrens(matherId);				
			var items = from child in list
				select new ListViewItem() { Text = string.Format("{0} {1} {2}", child.LastName, child.FirstName, child.MiddleName), Tag = child.Id, Selected = this.childId.HasValue && child.Id == this.childId.Value};
			this.lvChildren.Items.Clear();
			this.lvChildren.Items.AddRange(items.ToArray());
		}
		
		private void BindMather(int matherId)
		{
			Mather mather = MatherBL.GetMather(matherId);
			this.tbMatherFirstName.Text = mather.FirstName;
			this.tbMatherMiddleName.Text = mather.MiddleName;
			this.tbMatherLastName.Text = mather.LastName;
			this.nudBornYear.Value = mather.Age;
			this.rtbMatherAddress.Text = mather.Address;
			this.nudBornCount.Value = mather.BornCount;
			this.tbChildHistory.Text = mather.ChildHistory;
			this.rtbCurrentHistory.Text = mather.CurrentHistory;
			this.nudHoldDays.Value = mather.HoldDays;
			this.rtbMatherState.Text = mather.State;
			this.matherId = matherId;
		}
		
		int ? matherId = null;
		
		private void AddMather()
		{
			Mather mather = new Mather();
			mather.FirstName = this.tbMatherFirstName.Text;
			mather.MiddleName = this.tbMatherMiddleName.Text;
			mather.LastName = this.tbMatherLastName.Text;
			mather.Age = (int)this.nudBornYear.Value;
			mather.Address = this.rtbMatherAddress.Text;
			mather.BornCount = (int)this.nudBornCount.Value;
			mather.ChildHistory = this.tbChildHistory.Text;
			mather.CurrentHistory = this.rtbCurrentHistory.Text;
			mather.HoldDays = (int)this.nudHoldDays.Value;
			mather.State = this.rtbMatherState.Text;
			
			this.matherId = MatherBL.AddMather(mather);			
		}
		
		private void UpdateMather()
		{
			if(this.matherId.HasValue)
			{
				Mather mather = new Mather();
				mather.Id = this.matherId.Value;
				mather.FirstName = this.tbMatherFirstName.Text;
				mather.MiddleName = this.tbMatherMiddleName.Text;
				mather.LastName = this.tbMatherLastName.Text;
				mather.Age = (int)this.nudBornYear.Value;
				mather.Address = this.rtbMatherAddress.Text;
				mather.BornCount = (int)this.nudBornCount.Value;
				mather.ChildHistory = this.tbChildHistory.Text;
				mather.CurrentHistory = this.rtbCurrentHistory.Text;
				mather.HoldDays = (int)this.nudHoldDays.Value;
				mather.State = this.rtbMatherState.Text;
				
				MatherBL.UpdateMather(mather);
				this.BindMatherList();
			}
		}
		
		private void BindChild(int childId)
		{
			Child child = ChildBL.GetChild(childId);
			tbChildFirstName.Text = child.FirstName;
			tbChildMiddleName.Text = child.MiddleName;
			tbChildLastName.Text = child.LastName;
			datetimepickerChildBornDate.Value = child.BornDate;
			nudOnMatherWeeks.Value = child.OnMatherWeeks;
			nudBornNumber.Value = child.BornNumber;
			rtbHospitalState.Text = child.HospitalState;
			rtbCurrentState.Text = child.CurrentState;
			tbBornWeight.Text = child.BornWeight.ToString();
			tbCurrentWeight.Text = child.CurrentWeight.ToString();
			tbBornHeight.Text = child.BornHeight.ToString();
			rtbRecomendation.Text = child.Recomendation;
			rtbOther.Text = child.Other;
			this.childId = childId;
		}
		
		private int ? childId;
		
		public void AddChild(int matherId)
		{
			Child child = new Child();
			child.MatherId = matherId;
			child.FirstName = tbChildFirstName.Text;
			child.MiddleName = tbChildMiddleName.Text;
			child.LastName = tbChildLastName.Text;
			child.BornDate = datetimepickerChildBornDate.Value;
			child.OnMatherWeeks = (int)nudOnMatherWeeks.Value;
			child.BornNumber = (int)nudBornNumber.Value;
			child.HospitalState = rtbHospitalState.Text;
			child.CurrentState = rtbCurrentState.Text;
			child.BornWeight = (float)Convert.ToDouble(tbBornWeight.Text);
			child.CurrentWeight = (float)Convert.ToDouble(tbCurrentWeight.Text);
			child.BornHeight = (float)Convert.ToDouble(tbBornHeight.Text);
			child.Recomendation = rtbRecomendation.Text;
			child.Other = rtbOther.Text;
			
			this.childId = ChildBL.AddChild(child);
		}
		
		public void UpdateChild(int matherId)
		{
			if(this.childId.HasValue)
			{
				Child child = new Child();
				child.Id = this.childId.Value;
				child.MatherId = matherId;
				child.FirstName = tbChildFirstName.Text;
				child.MiddleName = tbChildMiddleName.Text;
				child.LastName = tbChildLastName.Text;
				child.BornDate = datetimepickerChildBornDate.Value;
				child.OnMatherWeeks = (int)nudOnMatherWeeks.Value;
				child.BornNumber = (int)nudBornNumber.Value;
				child.HospitalState = rtbHospitalState.Text;
				child.CurrentState = rtbCurrentState.Text;
				child.BornWeight = (float)Convert.ToDouble(tbBornWeight.Text);
				child.CurrentWeight = (float)Convert.ToDouble(tbCurrentWeight.Text);
				child.BornHeight = (float)Convert.ToDouble(tbBornHeight.Text);
				child.Recomendation = rtbRecomendation.Text;
				child.Other = rtbOther.Text;
				
				ChildBL.UpdateChild(child);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.SaveDepartment();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.BindDepartment();
			this.BindMatherList();
			this.BindMatherChildList();
		}
		
		void BtnNewMatherClick(object sender, EventArgs e)
		{
			if(this.ValidateMather())
			{
				//this.btnNewMather.BackColor =Color.Green;
				this.AddMather();
				this.BindMatherList();
				this.BindMatherChildList();
			}
			else
			{
				//this.btnNewMather.BackColor =Color.Red;
			}
		}
		
		void BtnSaveMatherClick(object sender, EventArgs e)
		{
			if(this.ValidateMather())
			{
				//this.btnSaveMather.BackColor =Color.Green;
				this.UpdateMather();
				this.BindMatherList();
				this.BindMatherChildList();
			}
			else
			{
				//this.btnSaveMather.BackColor =Color.Red;
			}
		}
		
		void TbMatherSearchChildrenTextChanged(object sender, EventArgs e)
		{
			this.BindMatherChildList();
		}
		
		void TbMatherSearchTextChanged(object sender, EventArgs e)
		{
			this.BindMatherList();
		}
		
		void LvMathersSelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.lvMathers.SelectedItems.Count > 0)
			{
				this.BindMather((int)this.lvMathers.SelectedItems[0].Tag);
			}
			else
			{
				this.matherId = null;
			}
		}
		
		void LvMatherChildrenSelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.lvMatherChildren.SelectedItems.Count > 0)
			{
				this.BindChilds((int)this.lvMatherChildren.SelectedItems[0].Tag);
				this.CleanChild();
			}
		}
		
		void LvChildrenSelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.lvChildren.SelectedItems.Count > 0)
			{
				this.BindChild((int)this.lvChildren.SelectedItems[0].Tag);
			}
			else
			{
				this.childId = null;
			}
		}
		
		private bool ValidateMather()
		{
			bool result = this.tbMatherFirstName.Text.Trim().Length > 0;
			result = result && this.tbMatherMiddleName.Text.Trim().Length > 0;
			result = result && this.tbMatherLastName.Text.Trim().Length > 0;
			result = result && this.nudBornYear.Value > 0;			
			result = result && this.nudBornCount.Value > 0;						
			result = result && this.nudHoldDays.Value > 0;
			
			//(FirtName + ' ' + MiddleName + ' ' + LastName) Like(@searchexpr)
			
			if(MatherBL.GetMathers(string.Format("{0} {1} {2}", this.tbMatherLastName.Text.Trim(), this.tbMatherFirstName.Text.Trim(), this.tbMatherMiddleName.Text.Trim())).Count > 0)
			{
				result = false;
			}
			
			return result;			
		}
		
		private bool ValidateChild()
		{
			float temp;
			bool result = this.lvMatherChildren.SelectedItems.Count > 0;
			result = result &&  tbChildFirstName.Text.Trim().Length > 0;			
			result = result &&  tbChildMiddleName.Text.Trim().Length > 0;
			result = result &&  tbChildLastName.Text.Trim().Length > 0;			
			result = result &&  nudOnMatherWeeks.Value > 0;
			result = result &&  nudBornNumber.Value > 0;
			result = result &&  float.TryParse(tbBornWeight.Text, out temp);
			result = result &&  float.TryParse(tbCurrentWeight.Text, out temp);
			result = result &&  float.TryParse(tbBornHeight.Text, out temp);
			
			return result;
		}
		
		void BtnNewChildClick(object sender, EventArgs e)
		{
			if(this.ValidateChild())
			{
				//this.btnNewChild.BackColor = Color.Green;
				this.AddChild((int)this.lvMatherChildren.SelectedItems[0].Tag);
				this.BindChilds((int)this.lvMatherChildren.SelectedItems[0].Tag);
			}
			else
			{
				//this.btnNewChild.BackColor = Color.Red;
			}
		}
		
		void BtnSaveChildClick(object sender, EventArgs e)
		{
			if(this.ValidateChild() && this.lvChildren.SelectedItems.Count > 0)
			{
				//this.btnSaveChild.BackColor = Color.Green;
				this.UpdateChild((int)this.lvMatherChildren.SelectedItems[0].Tag);
				this.BindChilds((int)this.lvMatherChildren.SelectedItems[0].Tag);
			}
			else
			{
				//this.btnSaveChild.BackColor = Color.Red;
			}
		}
		
		private void CleanChild()
		{
			tbChildFirstName.Clear();
			tbChildMiddleName.Clear();
			tbChildLastName.Clear();
			datetimepickerChildBornDate.ResetText();
			nudOnMatherWeeks.ResetText();
			nudBornNumber.ResetText();
			rtbHospitalState.Clear();
			rtbCurrentState.Clear();
			tbBornWeight.Clear();
			tbCurrentWeight.Clear();
			tbBornHeight.Clear();
			rtbRecomendation.Clear();
			rtbOther.Clear();
			this.childId = null;
		}
	}
}
