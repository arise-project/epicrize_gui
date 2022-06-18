/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 14.01.2010
 * Time: 23:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

using LibraryBusinessLogic;

namespace EpicrizeGui
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{			
			//ConfigurationManager.OpenExeConfiguration(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EpicrizeGui.exe.config"));
			Repository.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			
			LoginForm login = new LoginForm();
			if(login.ShowDialog() == DialogResult.OK)
			{
				Application.Run(new MainForm());
			}			
		}		
	}
}
