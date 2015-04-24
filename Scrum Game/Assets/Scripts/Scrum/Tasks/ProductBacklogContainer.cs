using UnityEngine;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[System.Serializable, XmlRoot("BACK_LOGS")]
public class ProductBacklogContainer 
{
	[XmlArray("BACKLOGS"), XmlArrayItem("PRODUCT_BACKLOG")]
	public List<ProductBacklogProperties> backlogItens = new List<ProductBacklogProperties>();

	public ProductBacklogContainer()
	{
	}
}
