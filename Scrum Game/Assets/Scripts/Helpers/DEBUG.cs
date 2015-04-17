using UnityEngine;
using System.Collections;

public class DEBUG
{
	public static void Log(object pMessage, Object pContext = null)
	{
#if UNITY_EDITOR
		Debug.Log(pMessage, pContext);
#endif
	}

	public static void LogError(object pMessage, Object pContext = null)
	{
		#if UNITY_EDITOR
		Debug.LogError(pMessage, pContext);
		#endif
	}
}
