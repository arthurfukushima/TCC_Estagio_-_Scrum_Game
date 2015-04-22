using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	private static GameManager instance;

	public static GameManager Instance
	{
		get{
			if(!instance)
				instance = FindObjectOfType (typeof(GameManager)) as GameManager;

			return instance;
		}
	}

	void Awake()
	{
		if(instance != null && instance != this)
		{
			Destroy(gameObject);
			return;
		}
		else
			instance = this;

		DontDestroyOnLoad(this);
	}
}

