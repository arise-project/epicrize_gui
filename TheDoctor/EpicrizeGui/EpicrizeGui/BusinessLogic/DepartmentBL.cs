/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 22:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;

using EpicrizeGui.Entity;
using LibraryBusinessLogic;

namespace EpicrizeGui.BusinessLogic
{
	/// <summary>
	/// Description of DepartmentBL.
	/// </summary>
	public static class DepartmentBL
	{
		static DepartmentBL()
		{
		}
		
		public static Department GetDepartment()
		{			
			var result = Repository.Select<Department>("GetDepartment", null);			
			return result.FirstOrDefault() ?? new Department();
		}
		
		public static void SaveDepartment(Department department)
		{
			var paremeters = new List<SqlParameter>()
			{
				new SqlParameter("DepartmentName", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, department.DepartmentName),
				new SqlParameter("DepartmentAddress", SqlDbType.NVarChar, 2000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, department.DepartmentAddress),
				new SqlParameter("Identifier", SqlDbType.NVarChar, 8, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, department.Identifier)
			};
			
			Repository.NoQuery("SetDepartment", paremeters);
		}
	}
}
