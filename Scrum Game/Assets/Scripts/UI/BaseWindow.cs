using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class BaseWindow : MonoBehaviour 
{
	public string windowID;

	protected virtual void Awake()
	{
		if(string.IsNullOrEmpty(windowID))
			windowID = this.name;

		UIManager.Instance.RegisterWindow(this);
	}

	public virtual void Open()
	{

	}

	protected virtual void OnOpen()
	{

	}

	public virtual void Close()
	{

	}

	protected virtual void OnClose()
	{
	
	}
}
