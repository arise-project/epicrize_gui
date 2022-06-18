/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 17.01.2010
 * Time: 22:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EpicrizeGui.Entity
{
	/// <summary>
	/// Description of IEntity.
	/// </summary>
	public interface IEntity
	{
		int Id
		{
			get;
			set;
		}
		
		void Save();
	}
}
