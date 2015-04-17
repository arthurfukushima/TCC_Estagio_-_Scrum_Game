using UnityEngine;
using System.Collections;

public class MainMenu : BaseWindow
{
	public BaseButton playButton;
	public BaseButton manualButton;
	public BaseButton settingsButton;
	public BaseButton exitButton;

	protected override void Awake ()
	{
		base.Awake ();
		playButton.AddOnClickListener(OnClickPlayButton);
		manualButton.AddOnClickListener(OnClickManualButton);
		settingsButton.AddOnClickListener(OnClickSettingsButton);
		exitButton.AddOnClickListener(OnClickExitButton);
	}

	public override void Open ()
	{
		base.Open ();

		gameObject.SetActive(true);
	}

	protected override void OnOpen ()
	{
		base.OnOpen ();
	}

	public override void Close ()
	{
		base.Close ();

		gameObject.SetActive(false);
	}

	protected override void OnClose ()
	{
		base.OnClose ();
	}

	#region BUTTONS
	private void OnClickPlayButton()
	{
		UIManager.Instance.OpenWindow("stgSelection");
	}

	private void OnClickManualButton()
	{
		UIManager.Instance.OpenWindow("manualAbout");
	}

	private void OnClickSettingsButton()
	{
		UIManager.Instance.OpenWindow("gameSettings");
	}

	private void OnClickExitButton()
	{
		//TODO Are you sure?
		Application.Quit();
	}
	#endregion
}
