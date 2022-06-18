/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 14.01.2010
 * Time: 23:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using EpicrizeGui.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LibraryBusinessLogic;
using WordDocumentBuilder;

namespace SimpleTester
{
	class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			//Regex templateRegexp = new Regex(@"\[\w+\.\w+\]");
			//Console.WriteLine(templateRegexp.Match("[Patient.FirstName]").Value);
			/*
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{			
				WordDocumentManager manager = new WordDocumentManager(openFileDialog.FileName);
				manager.Open();
				DocumentInsert.InsertEntity<Title>(manager.Document, new Title() { Caption = "caption" });
				DocumentInsert.InsertEntity<Patient>(manager.Document, new Patient() { FirstName = "firstName", LastName = "lastname" });
				DocumentInsert.InsertEntityList<Epicrize>(manager.Document, new List<Epicrize>(){ new Epicrize() { Date = DateTime.Now, Diagnose = "Diagnose 2" },  new Epicrize() { Date = DateTime.Now, Diagnose = "Diagnose 1" }});
				
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				if(saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					manager.SaveAs(saveFileDialog.FileName);
				}
			}
			*/
			
			string login;
			string password;
			login = Console.ReadLine();
			password = Console.ReadLine();
			
			Repository.ConnectionString = @"Data Source=YOUR-3CE9044318\SQLEXPRESS;Initial Catalog=MatherHospital;Integrated Security=SSPI;User Id=sa;Password=sqlserver";
			
			AuthenticationBL.AddUser(login, password);
			Console.WriteLine("Hello World!");
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}