using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class StageInfo
{
	public string stageName = "Stage Name...";
	public string stageID = "";
	public string stageDescription = "Description...";
}

public class DBStageInfos : MonoBehaviour 
{
	private static DBStageInfos instance;

	public List<StageInfo> stagesList = new List<StageInfo>();
	private Dictionary<string, StageInfo> stagesDictionary;

	public static DBStageInfos Instance
	{
		get
		{
			if(instance == null)
				instance = FindObjectOfType(typeof(DBStageInfos)) as DBStageInfos;

			return instance;
		}
	}

	public virtual void Start()
	{
		ReadStageInfoData();
	}

	private void ReadStageInfoData()
	{
		stagesDictionary = new Dictionary<string, StageInfo>();
	
		//TODO : Read a XML with stage Info
		foreach(StageInfo stage in stagesList)
		{
			stagesDictionary.Add(stage.stageID, stage);
		}
	}

	public StageInfo GetStageInfo(string pID)
	{
		if(stagesDictionary.ContainsKey(pID))
			return stagesDictionary[pID];
		else
		{
			DEBUG.LogError("Stage ID " + pID + " not found!");
			return null;
		}
	}
}
