using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogBallonWindow : BaseWindow 
{
	public List<GameObject> ballons = new List<GameObject>();

	private int currentStep = 0;

	private GameObject currentDialogBallon;
	public BaseButton nextDialogButton;
	public BaseButton prevDialogButton;
	
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
}