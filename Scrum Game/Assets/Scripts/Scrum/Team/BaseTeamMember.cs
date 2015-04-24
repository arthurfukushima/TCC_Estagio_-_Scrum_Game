using System.Xml;
using System.Xml.Serialization;

[System.Serializable]
public class BaseTeamMember
{
	[XmlAttribute("NAME")]
	public string memberName = "John";
	[XmlAttribute("DESCRIPTION")]
	public string memberDescription = "Doe";

	[XmlAttribute("JOB")]
	public TASK_AREA memberJob;

	public BaseTeamMember()
	{
	}

	public BaseTeamMember(string pName, string pDescription, TASK_AREA pJob)
	{
		memberName = pName;
		memberDescription = pDescription;
		memberJob = pJob;
	}
}
