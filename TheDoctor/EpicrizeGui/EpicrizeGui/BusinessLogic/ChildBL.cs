/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 22:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using EpicrizeGui.Entity;
using LibraryBusinessLogic;

namespace EpicrizeGui.BusinessLogic
{
	/// <summary>
	/// Description of ChildBL.
	/// </summary>
	public static class ChildBL
	{
		static ChildBL()
		{
		}
		
		public static List<Child> GetChildrens(int matherId)
		{
			var parameters = new List<SqlParameter>()
			{
				new SqlParameter("MatherId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, matherId)				
			};
			
			return Repository.Select<Child>("GetChilds", parameters);
		}
		
		public static Child GetChild(int Id)
		{
			var parameters = new List<SqlParameter>()
			{
				new SqlParameter("Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, Id)				
			};
			
			return Repository.Select<Child>("GetChild", parameters).First();
		}
		
		public static int AddChild(Child child)
		{			
			var parameters = new List<SqlParameter>()
			{
				new SqlParameter("MatherId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.MatherId),
				new SqlParameter("FirstName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.FirstName),
				new SqlParameter("MiddleName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.MiddleName),
				new SqlParameter("LastName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.LastName),
				new SqlParameter("BornDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.BornDate),
				new SqlParameter("OnMatherWeeks", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.OnMatherWeeks),
				new SqlParameter("BornNumber", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.BornNumber),
				new SqlParameter("HospitalState", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.HospitalState),
				new SqlParameter("CurrentState", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.CurrentState),
				new SqlParameter("BornWeight", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.BornWeight),
				new SqlParameter("CurrentWeight", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.CurrentWeight),
				new SqlParameter("BornHeight", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.BornHeight),
				new SqlParameter("Recomendation", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.Recomendation),
				new SqlParameter("Other", SqlDbType.NVarChar, 4000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.Other)
			};
			
			return (int)Repository.Scalar<decimal>("AddChild", parameters);
		}
		
		public static void UpdateChild(Child child)
		{
			var parameters = new List<SqlParameter>()
			{
				new SqlParameter("Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.Id),
				new SqlParameter("MatherId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.MatherId),
				new SqlParameter("FirstName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.FirstName),
				new SqlParameter("MiddleName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.MiddleName),
				new SqlParameter("LastName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.LastName),
				new SqlParameter("BornDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.BornDate),
				new SqlParameter("OnMatherWeeks", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.OnMatherWeeks),
				new SqlParameter("BornNumber", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.BornNumber),
				new SqlParameter("HospitalState", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.HospitalState),
				new SqlParameter("CurrentState", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.CurrentState),
				new SqlParameter("BornWeight", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.BornWeight),
				new SqlParameter("CurrentWeight", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.CurrentWeight),
				new SqlParameter("BornHeight", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.BornHeight),
				new SqlParameter("Recomendation", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.Recomendation),
				new SqlParameter("Other", SqlDbType.NVarChar, 4000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, child.Other)
			};
			
			Repository.NoQuery("UpdateChild", parameters);
		}
	}
}
