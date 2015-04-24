using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProductBacklogTicketsPopup : BasePopup
{
	public Transform ticketsBoard;

//	private const string backlogTicketPrefabName = "UI/Backlog_Ticket";
	public GameObject backlogTicketGO;

	protected override void Awake ()
	{
		base.Awake ();
		CreateTickets();
	}

	public override void Open ()
	{
		base.Open ();
	}

	protected override void OnClickClosePopup ()
	{
		base.OnClickClosePopup ();
		Close();
	}

	private void CreateTickets()
	{
		List<ProductBacklogProperties> backlogItens = ProductManager.Instance.ProductBacklog.backlogItens;
		
		for(int i = 0; i < backlogItens.Count; i++)
		{
			GameObject ticket = Instantiate(backlogTicketGO, Vector3.zero, Quaternion.identity) as GameObject;
			ticket.name = backlogItens[i].backlogItemName;
			ticket.transform.SetParent(ticketsBoard);
			ticket.transform.localScale = Vector3.one;
			ticket.SetActive(true);

			ProductBacklogTicket pbTicket = ticket.GetComponent<ProductBacklogTicket>();

			if(pbTicket)
			{
				pbTicket.Initialize(backlogItens[i]);
			}
		}
	}
}
