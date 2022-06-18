/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 22:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using EpicrizeGui.BusinessLogic;
using System;

namespace EpicrizeGui.Entity
{
	/// <summary>
	/// Description of Child.
	/// </summary>
	public class Child : IEntity
	{
		public Child()
		{
		}
		
		public int Id {
			get;
			set;
		}
		
		public int MatherId
		{
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
		
		public DateTime BornDate
		{
			get;
			set;
		}
		public int OnMatherWeeks
		{
			get;
			set;
		}
		public int BornNumber
		{
			get;
			set;
		}
		public string HospitalState
		{
			get;
			set;
		}
		public string CurrentState
		{
			get;
			set;
		}
		
		public float BornWeight
		{
			get;
			set;
		}
		public float CurrentWeight
		{
			get;
			set;
		}
		public float BornHeight
		{
			get;
			set;
		}
		public string Recomendation
		{
			get;
			set;
		}
		
		public string Other
		{
			get;
			set;
		}
		
		public void Save()
		{
			ChildBL.UpdateChild(this);
		}
	}
}
