/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 14.01.2010
 * Time: 23:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;
using System.Collections.Generic;

namespace WordDocumentBuilder
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class WordDocumentManager
	{
		private string filename;
		
		public WordDocumentManager(string filename)
		{
			this.filename = filename;
			this.Document = new XmlDocument();
			
		}
		
		public XmlDocument Document
		{
			get;	
			private set;
		}
		
		public void Open()
		{			
			this.Document.Load(this.filename);
		}
		
		public void SaveAs(string filename)
		{
			this.Document.Save(filename);
		}
	}
}