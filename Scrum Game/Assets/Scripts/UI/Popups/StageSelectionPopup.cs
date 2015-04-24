using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageSelectionPopup : BasePopup
{
	public Text titleText;
	public Text descriptionText;
	public Image imageIcon;

	public BaseButton playButton;

	protected override void Awake ()
	{
		base.Awake ();

		if(playButton)
			playButton.AddOnClickListener(OnClickPlayButton);
	}

	protected override void OnClickClosePopup ()
	{
		base.OnClickClosePopup ();
		Close();
	}

	public void UpdateInfos(string pTitle, string pDescription, Sprite pImageIcon)
	{
		titleText.text = pTitle;
		descriptionText.text = pDescription;
		imageIcon.sprite = pImageIcon;
	}

	private void OnClickPlayButton()
	{
		Application.LoadLevel(1);
	}
}
