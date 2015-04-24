using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TeamMemberDetailPanel : MonoBehaviour 
{
	public Image memberPortrait;
	public Text details;

	public void LoadDetails(BaseTeamMember pMember)
	{
		details.text = string.Format("Name: {0} \n Job: {1} \n Description: {2}", 
		                     pMember.memberName, pMember.memberJob.ToString(), pMember.memberDescription);
	}
}
