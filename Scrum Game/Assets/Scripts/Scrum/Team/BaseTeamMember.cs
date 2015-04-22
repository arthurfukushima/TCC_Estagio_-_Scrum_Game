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
	public JOB memberJob = JOB.PROGRAMMER;

	public BaseTeamMember()
	{
	}

	public BaseTeamMember(string pName, string pDescription, JOB pJob)
	{
		memberName = pName;
		memberDescription = pDescription;
		memberJob = pJob;
	}
}
