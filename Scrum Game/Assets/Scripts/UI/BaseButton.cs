using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BaseButton : MonoBehaviour 
{
	public string buttonID;
	public Button button;

	private Image buttonImage;

	protected virtual void Awake()
	{
		if(!button)
		{
			button = GetComponent<Button>();

			if(!button)
			{
				this.enabled = false;
				return;
			}
		}

		if(string.IsNullOrEmpty(buttonID))
			buttonID = this.name;

		UIManager.Instance.RegisterButton(this);
	}

	public void AddOnClickListener(UnityEngine.Events.UnityAction pAction)
	{
		button.onClick.AddListener(pAction);
	}

	public void RemoveOnClickListener(UnityEngine.Events.UnityAction pAction)
	{
		button.onClick.RemoveListener(pAction);
	}

	public void RemoveAllListeners()
	{
		button.onClick.RemoveAllListeners();
	}

	public Sprite GetButtonSprite()
	{
		if(!buttonImage)
			buttonImage = GetComponent<Image>();

		return buttonImage.sprite;
	}
}
