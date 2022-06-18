/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 22:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EpicrizeGui.Entity
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Department : IEntity
	{
		public Department()
		{
		}
		
		public int Id {
			get;
			set;
		}
		
		public string DepartmentName
		{
			get;
			set;
		}
		
		public string DepartmentAddress
		{
			get;
			set;
		}
		
		public string Identifier
		{
			get;
			set;
		}
		
		public char IdentifierN1
		{
			get
			{
				if(Identifier.Length > 0)
				{
					return Identifier[0];
				}
				
				return ' ';
			}
		}
		
		public char IdentifierN2
		{
			get
			{
				if(Identifier.Length > 1)
				{
					return Identifier[1];
				}
				
				return ' ';
			}
		}
		
		public char IdentifierN3
		{
			get
			{
				if(Identifier.Length > 2)
				{
					return Identifier[2];
				}
				
				return ' ';
			}
		}
		
		public char IdentifierN4
		{
			get
			{
				if(Identifier.Length > 3)
				{
					return Identifier[3];
				}
				
				return ' ';
			}
		}
		
		public char IdentifierN5
		{
			get
			{
				if(Identifier.Length > 4)
				{
					return Identifier[4];
				}
				
				return ' ';
			}
		}
		
		public char IdentifierN6
		{
			get
			{
				if(Identifier.Length > 5)
				{
					return Identifier[5];
				}
				
				return ' ';
			}
		}
		
		public char IdentifierN7
		{
			get
			{
				if(Identifier.Length > 6)
				{
					return Identifier[6];
				}
				
				return ' ';
			}
		}
		
		public char IdentifierN8
		{
			get
			{
				if(Identifier.Length > 7)
				{
					return Identifier[7];
				}
				
				return ' ';
			}
		}
		
		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
