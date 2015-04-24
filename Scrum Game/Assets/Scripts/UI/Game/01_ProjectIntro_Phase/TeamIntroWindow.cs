using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TeamIntroWindow : BaseWindow 
{
	public List<GameObject> ballons = new List<GameObject>();

	private int currentStep = 0;

	private GameObject currentDialogBallon;
	public BaseButton nextDialogButton;
	public BaseButton prevDialogButton;

	public TeamMemberDetailPanel memberDetailPanel;
	
	protected override void Awake ()
	{
		base.Awake ();

		if(nextDialogButton)
			nextDialogButton.AddOnClickListener(OnClickNextDialogButton);

		if(prevDialogButton)
			prevDialogButton.AddOnClickListener(OnClickPrevDialogButton);
	}

	public override void Open ()
	{
		base.Open ();
		gameObject.SetActive(true);

		if(ballons == null || ballons.Count < 1)
			return;

		for(int i = 0; i < ballons.Count; i++)
		{
			if(i != 0)
				ballons[i].SetActive(false);
		}


	}

	public override void Close ()
	{
		base.Close ();
		gameObject.SetActive(false);
	}

	private void OnClickNextDialogButton()
	{
		if(currentStep < ballons.Count - 1)
		{
			ballons[currentStep].SetActive(false);
			currentStep++;
			ballons[currentStep].SetActive(true);

			if(currentStep == 1)
				LoadMembersDetails();
		}
		else
		{
			UIManager.Instance.OpenWindow("ProductIntroWindow");
		}
	}

	private void OnClickPrevDialogButton()
	{
		if(currentStep > 0)
		{
			ballons[currentStep].SetActive(false);
			currentStep--;
			ballons[currentStep].SetActive(true);
		}
	}

	private void LoadMembersDetails()
	{
		List<BaseTeamMember> teamMembers = TeamMembersManager.Instance.membersContainer.teamMembers;

		if(teamMembers != null && teamMembers.Count > 0)
		{
			Transform panelParent = memberDetailPanel.transform.parent;

			for(int i = 0; i < teamMembers.Count; i++)
			{
				GameObject newPanel = Instantiate(memberDetailPanel.gameObject, Vector3.zero, Quaternion.identity) as GameObject;
				newPanel.transform.SetParent(panelParent, false);
				newPanel.GetComponent<TeamMemberDetailPanel>().LoadDetails(teamMembers[i]);
			}

			memberDetailPanel.gameObject.SetActive(false);
		}
	}
}