using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UIManager : MonoBehaviour 
{
	private static UIManager instance;

	private Dictionary<string, BaseWindow> window = new Dictionary<string, BaseWindow>();
	private Dictionary<string, BasePopup> popups = new Dictionary<string, BasePopup>();
	private Dictionary<string, BaseButton> buttons = new Dictionary<string, BaseButton>();
	
	private BaseWindow lastOpennedWindow;
	private BaseWindow currentOpenWindow;

	private List<BasePopup> currentOpenPopups = new List<BasePopup>();

	public static UIManager Instance
	{
		get{
			if(instance == null)
				instance = FindObjectOfType(typeof(UIManager)) as UIManager;

			return instance;
		}
	}

	#region WINDOWS
	public void RegisterWindow(BaseWindow pWindow)
	{
		if(!window.ContainsKey(pWindow.windowID))
			window.Add(pWindow.windowID, pWindow);
		else
			DEBUG.LogError("Register Window: Duplicated window ID! (" + pWindow.windowID + ").", pWindow);

		pWindow.Close();
	}

	public BaseWindow GetWindow(string pID)
	{
		if(window.ContainsKey(pID))
			return window[pID];
		else
		{
			DEBUG.LogError("Window " + pID + " not found!");
			return null;
		}
	}

	public void OpenWindow(string pID)
	{
		BaseWindow window = GetWindow(pID);

		if(window && window != currentOpenWindow)
		{
			lastOpennedWindow = currentOpenWindow;
			CloseWindow(currentOpenWindow);

			window.Open();
			currentOpenWindow = window;
		}
	}

	public void CloseWindow(BaseWindow pWindow)
	{
		if(pWindow)
			pWindow.Close();
	}
	#endregion

	#region POPUPS
	public void RegisterPopup(BasePopup pPopup)
	{
		if(!popups.ContainsKey(pPopup.popupID))
			popups.Add(pPopup.popupID, pPopup);
		else
			DEBUG.LogError("Register Popup: Duplicated Popup ID! (" + pPopup.popupID + ").", pPopup);

		pPopup.Close();
	}
	
	public BasePopup GetPopup(string pID)
	{
		if(popups.ContainsKey(pID))
			return popups[pID];
		else
		{
			DEBUG.LogError("Popup " + pID + " not found!");
			return null;
		}
	}

	public BasePopup OpenPopup(string pID)
	{
		BasePopup popup = GetPopup(pID);
		popup.Open();
		currentOpenPopups.Add(popup);

		return popup;
	}
	#endregion

	#region BUTTONS
	public void RegisterButton(BaseButton pButton)
	{
		if(!buttons.ContainsKey(pButton.buttonID))
			buttons.Add(pButton.buttonID, pButton);
		else
			DEBUG.LogError("Register Button: Duplicated button ID! (" + pButton.buttonID + ").", pButton);
	}

	public BaseButton GetButton(string pID)
	{
		if(buttons.ContainsKey(pID))
			return buttons[pID];
		else
		{
			DEBUG.LogError("Button " + pID + " not found!");
			return null;
		}
	}
	#endregion
}
