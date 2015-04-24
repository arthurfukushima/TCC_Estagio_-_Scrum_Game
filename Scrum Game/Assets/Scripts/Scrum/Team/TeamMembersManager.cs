using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TeamMembersManager : MonoBehaviour 
{
	private static TeamMembersManager instance;
	public static TeamMembersManager Instance
	{
		get{
			if(instance == null)
				instance = FindObjectOfType(typeof(TeamMembersManager)) as TeamMembersManager;

			return instance;
		}
	}

	public TeamMembersContainer membersContainer;

	void Awake()
	{
		membersContainer = XMLSerializer.Load<TeamMembersContainer>("TeamMembers.xml");
		Debug.Log("Load Members");
	}
}
