using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XMLSerializer
{
	private static string path = Application.persistentDataPath;

	public void Save<T>(string pXMLName = null)
	{
		if(string.IsNullOrEmpty(pXMLName))
		{
			Debug.LogError ("Name not found...");
			return;
		}

		string completePath = path + "/" + pXMLName;
		var serializer = new XmlSerializer(typeof(T));

		using(var stream = new FileStream(completePath, FileMode.Create))
		{
			serializer.Serialize(stream, this);
		}
	}

	public static T Load<T>(string pXMLName)
	{
		if(string.IsNullOrEmpty(pXMLName))
		{
			Debug.LogError ("Name not found...");
			return default(T);
		}
		
		string completePath = path + "/" + pXMLName;
		var serializer = new XmlSerializer(typeof(T));
		
		using(var stream = new FileStream(completePath, FileMode.Open))
		{
			return (T)serializer.Deserialize(stream);
		}
	}

	public static void LoadXML(string pXMLName)
	{

	}
}
