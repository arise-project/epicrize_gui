/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 22:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using LibraryBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using EpicrizeGui.Entity;

namespace EpicrizeGui.BusinessLogic
{
	/// <summary>
	/// Description of MatherBL.
	/// </summary>
	public static class MatherBL
	{
		static MatherBL()
		{
		}
		
		public static List<Mather> GetMathers(string searchExpression)
		{
			var parameters = new List<SqlParameter>()
			{
				new SqlParameter("searchexpr", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, searchExpression)				
			};
			
			return Repository.Select<Mather>("GetMathers", parameters);
		}
		
		public static Mather GetMather(int id)
		{
			var parameters = new List<SqlParameter>()
			{
				new SqlParameter("Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, id)				
			};
			
			return Repository.Select<Mather>("GetMather", parameters).First();
		}
		
		public static int AddMather(Mather mather)
		{
			var parameters = new List<SqlParameter>()
			{
				new SqlParameter("FirstName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.FirstName),				
				new SqlParameter("MiddleName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.MiddleName),				
				new SqlParameter("LastName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.LastName),				
				new SqlParameter("Age", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.Age),				
				new SqlParameter("Address", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.Address),				
				new SqlParameter("BornCount", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.BornCount),	
				new SqlParameter("ChildHistory", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.ChildHistory),
				new SqlParameter("CurentHistory", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.CurrentHistory),
				new SqlParameter("HoldDays", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.HoldDays),
				new SqlParameter("State", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.State)
			};
			
			return (int)Repository.Scalar<decimal>("AddMather", parameters);
		}
		
		public static void UpdateMather(Mather mather)
		{
			var parameters = new List<SqlParameter>()
			{
				new SqlParameter("Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.Id),
				new SqlParameter("FirstName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.FirstName),				
				new SqlParameter("MiddleName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.MiddleName),				
				new SqlParameter("LastName", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.LastName),				
				new SqlParameter("Age", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.Age),				
				new SqlParameter("Address", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.Address),				
				new SqlParameter("BornCount", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.BornCount),	
				new SqlParameter("ChildHistory", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.ChildHistory),
				new SqlParameter("CurentHistory", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.CurrentHistory),
				new SqlParameter("HoldDays", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.HoldDays),
				new SqlParameter("State", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, mather.State)
			};
			
			Repository.NoQuery("UpdateMather", parameters);
		}
	}
}
