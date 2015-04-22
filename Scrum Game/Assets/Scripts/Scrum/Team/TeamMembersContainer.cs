using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[System.Serializable, XmlRoot("TEAM_MEMBERS")]
public class TeamMembersContainer
{
	[XmlArray("MEMBERS"), XmlArrayItem("MEMBER")]
	public List<BaseTeamMember> teamMembers = new List<BaseTeamMember>();

	private static string defaultPath = Application.persistentDataPath + "/TeamMembers.xml";

	public TeamMembersContainer()
	{
	}

	public TeamMembersContainer(List<BaseTeamMember> pMembers)
	{
		teamMembers = pMembers;
	}

	public void Save(string pPath = null)
	{
		if(pPath == null)
			pPath = defaultPath;

		var serializer = new XmlSerializer(typeof(TeamMembersContainer));
		using(var stream = new FileStream(pPath, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
		{
			serializer.Serialize(stream, this);
		}
	}

	public static TeamMembersContainer Load(string pPath = null)
	{
		if(pPath == null)
			pPath = defaultPath;

		var serializer = new XmlSerializer(typeof(TeamMembersContainer));
		
		using(var stream = new FileStream(pPath, FileMode.Open))
		{
			return serializer.Deserialize(stream) as TeamMembersContainer;
		}
	}
}
