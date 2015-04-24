using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ProductBacklogTicket : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	public ProductBacklogProperties properties;
	public Text ticketName;

	private Button ticketButton;

	public void Awake()
	{
		if(!ticketButton)
			ticketButton = GetComponent<Button>();
	}

	public void Initialize(ProductBacklogProperties pProperties)
	{
		properties = pProperties;

		ticketName.text = properties.backlogItemName;
	}

	public void OnPointerEnter (PointerEventData pData)
	{
//		DEBUG.Log("On Pointer Enter");
	}

	public void OnPointerExit(PointerEventData pData)
	{
//		DEBUG.Log("On Pointer Exit");
	}
}
