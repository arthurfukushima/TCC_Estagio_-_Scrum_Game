using UnityEngine;
using System.Collections;

public class ManualWindow : BaseWindow
{
	public BaseButton backButton;

	protected override void Awake ()
	{
		base.Awake ();

		if(backButton)
			backButton.AddOnClickListener(OnClickBack);
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
}
