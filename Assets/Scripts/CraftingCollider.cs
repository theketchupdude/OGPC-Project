<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
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
>>>>>>> ee2817438609973a023a06543e53f3e4dca22188
