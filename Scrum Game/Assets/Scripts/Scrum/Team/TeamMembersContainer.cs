using UnityEngine;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[System.Serializable, XmlRoot("TEAM_MEMBERS")]
public class TeamMembersContainer
{
	public string projectName;

	[XmlArray("MEMBERS"), XmlArrayItem("MEMBER")]
	public List<BaseTeamMember> teamMembers = new List<BaseTeamMember>();

	private static string defaultPath = Application.persistentDataPath + "/TeamMembers.xml";

	public TeamMembersContainer()
	{
	}
}
