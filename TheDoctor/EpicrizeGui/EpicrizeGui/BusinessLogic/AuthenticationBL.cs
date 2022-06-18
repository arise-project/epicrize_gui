/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 17:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

using LibraryBusinessLogic;

namespace EpicrizeGui.BusinessLogic
{
	/// <summary>
	/// Description of AuthenticationBL.
	/// </summary>
	public static class AuthenticationBL
	{
		static AuthenticationBL()
		{
		}
		
		private static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
	    {
	        try
	        {    
	            //Create a new instance of RSACryptoServiceProvider.
	            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
	
	            //Import the RSA Key information. This only needs
	            //toinclude the public key information.
	            RSA.ImportParameters(RSAKeyInfo);
	
	            //Encrypt the passed byte array and specify OAEP padding.  
	            //OAEP padding is only available on Microsoft Windows XP or
	            //later.  
	            return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
	        }
	        //Catch and display a CryptographicException  
	        //to the console.
	        catch(CryptographicException e)
	        {
	            Console.WriteLine(e.Message);
	
	            return null;
	        }
	
	    }

		public static bool Authenticate(string login, string password)
		{
			ASCIIEncoding  encoding =new ASCIIEncoding();
			byte [] hash = new MD5CryptoServiceProvider().ComputeHash(encoding.GetBytes(password)).Take(50).ToArray();
			var paramenters = new List<SqlParameter>() 
			{
				new SqlParameter("Login", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, login),
				new SqlParameter("PasswordHash", SqlDbType.Binary, 50, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, hash)
			};
			
			return Repository.Scalar<int>("Authenticate", paramenters) > 0;			
		}
		
		public static void AddUser(string login, string password)
		{
			login = "user";
			password = "12345";
			ASCIIEncoding  encoding =new ASCIIEncoding();
			byte [] hash = new MD5CryptoServiceProvider().ComputeHash(encoding.GetBytes(password)).Take(50).ToArray();
			//byte [] hash = RSAEncrypt(encoding.GetBytes(password), new RSACryptoServiceProvider().ExportParameters(false), false).Take(50).ToArray();
			/*
			int sum = 0;
			foreach(byte b in hash)
			{
				sum+= b;
			}
			Console.WriteLine(sum);
			*/
			var paramenters = new List<SqlParameter>() 
			{
				new SqlParameter("Login", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, login),
				new SqlParameter("PasswordHash", SqlDbType.Binary, 50, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Default, hash)
			};
			
			Repository.NoQuery("AddUser", paramenters);			
		}
	}
}
