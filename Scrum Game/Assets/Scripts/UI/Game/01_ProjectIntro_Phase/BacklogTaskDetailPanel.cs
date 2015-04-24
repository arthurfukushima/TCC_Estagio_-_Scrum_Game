using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BacklogTaskDetailPanel : MonoBehaviour {

	public Image memberPortrait;
	public Text details;
	
	public void LoadDetails(ProductBacklogProperties pBacklogItem)
	{
		details.text = string.Format("Name: {0} \n Detail: {1} \n Priority: {2}", 
		                             pBacklogItem.backlogItemName, pBacklogItem.backlogItemDescription, pBacklogItem.backlogPriority.ToString());
	}
}
