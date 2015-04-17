using UnityEngine;
using System.Collections;

public class MainMenuInitializer : MonoBehaviour 
{
	public string startWindow = "mainMenu";

	void Start()
	{
		UIManager.Instance.OpenWindow(startWindow);
	}

}
