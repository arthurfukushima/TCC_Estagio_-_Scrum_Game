using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProductManager : MonoBehaviour 
{
	public bool save;

	private static ProductManager instance;
	[SerializeField]
	private ProductBacklogContainer productBackLog;

	public ProductBacklogContainer ProductBacklog
	{
		get{
			return productBackLog;
		}
	}
	public static ProductManager Instance
	{
		get{
			if(instance == null)
				instance = FindObjectOfType(typeof(ProductManager)) as ProductManager;

			return instance;
		}
	}

	void Awake()
	{
		if(save)
			XMLSerializer.Save<ProductBacklogContainer>(productBackLog, "ProductBacklog.xml");
		else
			productBackLog = XMLSerializer.Load<ProductBacklogContainer>("ProductBacklog.xml");
	}
}
