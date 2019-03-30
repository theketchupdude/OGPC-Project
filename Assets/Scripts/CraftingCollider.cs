using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingCollider : MonoBehaviour
{

	string craftingMaterial = "none";

	void OnCollisionEnter(Collision collision)
	{
		craftingMaterial = collision.gameObject.name;
	}

	void OnCollisionExit()
	{
		craftingMaterial = "none";
	}

	public string GetCraftingMaterial()
	{
		return craftingMaterial;
	}
}
