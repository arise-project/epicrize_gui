/*
 * Created by SharpDevelop.
 * User: Eugene
 * Date: 14.01.2010
 * Time: 23:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Xml;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordDocumentBuilder
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public static class DocumentInsert
	{
		private static Dictionary<Type, List<string>> typeCashe = new Dictionary<Type, List<string>>();
		
		public static void InsertEntity<T>(XmlDocument document, T entity)
		{
			AddTypeToCashe(typeof(T));
			
			Stack<XmlNode> nodes = new Stack<XmlNode>();
			
			foreach(XmlNode node in document.ChildNodes)
			{
				nodes.Push(node);				
			}	
			
			
			while(nodes.Count > 0)
			{
				XmlNode current = nodes.Pop();
				
				InsertEntity<T>(current, entity);
				
				foreach(XmlNode node in current.ChildNodes)
				{
					nodes.Push(node);				
				}
			}
		}
		
		public static void InsertEntityList<T>(XmlDocument document, List<T> entities)
		{
			AddTypeToCashe(typeof(T));
			
			Stack<XmlNode> nodes = new Stack<XmlNode>();
			
			foreach(XmlNode node in document.ChildNodes)
			{
				nodes.Push(node);				
			}	
			
			while(nodes.Count > 0)
			{
				XmlNode current = nodes.Pop();
				
				if(current.Value == "[RepeaterBegin]")
				{
					XmlNode currentBegin = current;
					
					while(currentBegin.NextSibling == null)
					{
						currentBegin = currentBegin.ParentNode;
					}
					
					XmlNode parent = currentBegin.ParentNode;
					XmlNode currentSibling = currentBegin;
					
					List<XmlNode> siblings = new List<XmlNode>();
					
					bool isEnd = false;
					bool hasEntity = false;
					Regex entityTemplate = new Regex(string.Format(@"\[{0}\.\w+\]", typeof(T).Name));
					do
					{
						isEnd = currentSibling.InnerText.Contains("[RepeaterEnd]");
						hasEntity = hasEntity || entityTemplate.Match(currentSibling.InnerText).Captures.Count > 0;
						//Console.WriteLine(currentSibling.Name);
						//Console.WriteLine(currentSibling.InnerText);
						siblings.Add(currentSibling);
						currentSibling = currentSibling.NextSibling;						
					}
					while(currentSibling != null && !isEnd);
					
					//Console.WriteLine("Has Entity {0}", hasEntity);
					
					if(hasEntity)
					{
						foreach(T entity in entities)
						{
							foreach(XmlNode node in siblings)
							{
								Stack<XmlNode> innerNodes = new Stack<XmlNode>();
								XmlNode copyNode = node.CloneNode(true);
								innerNodes.Push(copyNode);
								
								bool isRepeater = false;
								while(innerNodes.Count > 0)
								{
									XmlNode currentInnderNode =  innerNodes.Pop();
									if(currentInnderNode.Value == "[RepeaterBegin]" || currentInnderNode.Value == "[RepeaterEnd]")
									{
										isRepeater = true;
										break;
									}
									else
									{
										InsertEntity<T>(currentInnderNode, entity);
										foreach(XmlNode innerNode in currentInnderNode.ChildNodes)
										{
											innerNodes.Push(innerNode);
										}
									}									
								}
								
								if(!isRepeater)
								{
									parent.InsertAfter(copyNode, currentBegin);
								}
							}
						}
						
						foreach(XmlNode node in siblings)
						{
							parent.RemoveChild(node);
						}
					}
				}
				//InsertEntity(current, entity);
				
				foreach(XmlNode node in current.ChildNodes)
				{
					nodes.Push(node);				
				}
			}
		}
		
		private static void AddTypeToCashe(Type type)
		{
			if(!typeCashe.ContainsKey(type))
			{				
				typeCashe.Add(type, (from property in type.GetProperties()
				                     select property.Name).ToList());				
			}
		}
	
		private static string GetEntityPropertyTemplate(string typeName, string propertyName)
		{
			return string.Format(@"\[{0}\.{1}\]", typeName, propertyName);
		}
		
		private static void InsertEntity<T>(XmlNode node, T entity)
		{
			Regex templateRegexp = new Regex(@"\[\w+\.\w+\]");		
			
			if(node.Value != null && templateRegexp.Match(node.Value).Captures.Count > 0)
			{
				Type type = typeof(T);
				foreach(string property in typeCashe[type])
				{
					Regex replaceRegexp = new Regex(GetEntityPropertyTemplate(entity.GetType().Name, property));
					node.Value = replaceRegexp.Replace(node.Value, type.GetProperty(property).GetValue(entity, null).ToString());
				}
			}
			
		}
	}
	
}
