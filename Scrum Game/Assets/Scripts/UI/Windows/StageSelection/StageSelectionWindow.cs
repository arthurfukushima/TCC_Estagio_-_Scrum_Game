using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageSelectionWindow : BaseWindow
{
	public BaseButton backButton;

	protected override void Awake ()
	{
		base.Awake ();

		if(backButton)
		{
			backButton.AddOnClickListener(OnClickBack);
		}
	}

	public override void Open ()
	{
		base.Open ();
		gameObject.SetActive(true);
	}

	public override void Close ()
	{
		base.Close ();
		gameObject.SetActive(false);
	}

	public void OnClickBack()
	{
		UIManager.Instance.OpenWindow("mainMenu");
	}

	public void OnClickStage(StageSelectOptionButton pButton)
	{
		StageSelectionPopup popup = UIManager.Instance.OpenPopup("stgSelectDetail") as StageSelectionPopup;

		if(popup)
		{
			StageInfo info = DBStageInfos.Instance.GetStageInfo(pButton.stageID);
			popup.UpdateInfos(info.stageName, info.stageDescription, pButton.GetButtonSprite());
		}
	}
}
