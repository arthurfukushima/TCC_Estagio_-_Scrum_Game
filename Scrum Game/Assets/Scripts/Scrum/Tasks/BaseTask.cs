using System.Xml;
using System.Xml.Serialization;

[System.Serializable]
public class BaseTask
{
	[XmlElement("TASK_NAME")]
	public string name;
	[XmlElement("TASK_ID")]
	public string id;
	[XmlElement("TASK_AREA")]
	public TASK_AREA area;
	[XmlElement("TASK_DESCRIPTION")]
	public string description;
	[XmlElement("TASK_STATE")]
	public TASK_STATE state;
	[XmlElement("LENGHT_HOURS")]
	public int lenghtInHours;

	[XmlArray("DEPENDECIES"), XmlArrayItem("TASK_NAME")]
	public string[] dependenciesTasks;

	public BaseTask()
	{
	}
}
