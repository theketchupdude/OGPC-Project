using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingCollider : MonoBehaviour 
{
	
	string craftingMaterial = "none";

	void OnCollisionEnter(Collision collision)
	{
		craftingMaterial = collision.gameObject.name;
        gameObject.transform.parent.gameObject.GetComponent<Crafting>().UpdateRecipe();
	}
	
	void OnCollisionExit(Collision collision)
	{
		craftingMaterial = "none";
	}
	
	public string GetCraftingMaterial()
	{
		return craftingMaterial;
	}
}
