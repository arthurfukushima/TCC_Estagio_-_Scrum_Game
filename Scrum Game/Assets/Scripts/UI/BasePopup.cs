using UnityEngine;
using System.Collections;

public class BasePopup : MonoBehaviour 
{
	public string popupID;
	public BaseButton closeButton;

	protected virtual void Awake()
	{
		if(string.IsNullOrEmpty(popupID))
			popupID = this.name;
		
		UIManager.Instance.RegisterPopup(this);

		if(closeButton)
			closeButton.AddOnClickListener(OnClickClosePopup);
	}

	public virtual void Open()
	{
		gameObject.SetActive(true);
	}

	public virtual void Close()
	{
		gameObject.SetActive(false);
	}

	protected virtual void OnClickClosePopup()
	{
				
	}
}
