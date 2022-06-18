/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 15.01.2010
 * Time: 18:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using EpicrizeGui.BusinessLogic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EpicrizeGui
{
	/// <summary>
	/// Description of LoginForm.
	/// </summary>
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LoginFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			bool result = AuthenticationBL.Authenticate(this.tbLogin.Text.Trim(), this.tbPassword.Text);
			if(result)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			
		}
	}
}
