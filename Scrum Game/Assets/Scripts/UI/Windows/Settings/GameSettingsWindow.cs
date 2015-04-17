using UnityEngine;
using System.Collections;

public class GameSettingsWindow : BaseWindow
{
	public BaseButton backButton;

	protected override void Awake ()
	{
		base.Awake ();

		if(backButton)
			backButton.AddOnClickListener(OnClickBackButton);
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

	private void OnClickBackButton()
	{
		UIManager.Instance.OpenWindow("mainMenu");
	}
}
