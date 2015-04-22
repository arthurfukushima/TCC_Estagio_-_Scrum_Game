using UnityEngine;
using System.Collections;
using UnityEditor;

public class XmlEditor : EditorWindow
{
	public static XmlEditor window;

	private string data;

	[MenuItem("XML/XML Editor")]
	private static void Init()
	{
		if(!window)
			window = (XmlEditor)EditorWindow.GetWindow(typeof(XmlEditor), false, "XML Editor");
		else
		{
			window.Close();
			window = null;
		}
	}

	void OnGUI()
	{
		string fileName = "TeamMembers.xml";

		fileName = GUILayout.TextField(fileName);

		if(GUILayout.Button("LOAD"))
		{
			data = "KA KSANGksangk";
		}

		GUILayout.Box(data);

		EditorUtility.SetDirty(this);
	}
}
