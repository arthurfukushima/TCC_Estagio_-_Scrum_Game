using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

[System.Serializable]
public class ProductBacklogProperties
{
	public string backlogItemName = "";
	public string backlogItemDescription = "";
	[Range(1, 10)]
	public int backlogPriority = 10;

	[XmlArray("TASKS_LIST"), XmlArrayItem("TASK")]
	public List<BaseTask> tasks = new List<BaseTask>();

	public ProductBacklogProperties()
	{
	}
}
