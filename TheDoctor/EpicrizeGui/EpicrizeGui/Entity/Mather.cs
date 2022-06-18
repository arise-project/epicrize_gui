/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 22:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using EpicrizeGui.BusinessLogic;
using System;

namespace EpicrizeGui.Entity
{
	/// <summary>
	/// Description of Mather.
	/// </summary>
	public class Mather : IEntity
	{
		public Mather()
		{
		}
		
		public int Id {
			get;
			set;
		}
		
		public string FirstName
		{
			get;
			set;
		}
		
		public string MiddleName
		{
			get;
			set;
		}
		
		public string LastName
		{
			get;
			set;
		}
		
		public int Age
		{
			get;
			set;
		}
		
		public string Address
		{
			get;
			set;
		}
		
		public int BornCount
		{
			get;
			set;
		}
		
		public string ChildHistory
		{
			get;
			set;
		}
		
		public string CurrentHistory
		{
			get;
			set;
		}
		
		public int HoldDays
		{
			get;
			set;
		}
		
		public string State
		{
			get;
			set;
		}
		
		public void Save()
		{
			MatherBL.UpdateMather(this);
		}
	}
}
