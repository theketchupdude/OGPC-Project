using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
	int recipenum = 1;
	
	string[,] Materials = new string[2, 2];
	
	List<string[,]> Recipes;
	
	void Start () 
	{
		Recipes = new List<string[,]>();
	}
	
	void Update () 
	{
		
	}
	
	void CreateRecipe(string[,] recipe)
	{
		Recipes.Add(recipe);
	}
	
	void UpdateMaterials()
	{
		Materials[0,0] = this.gameObject.transform.GetChild(1).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[0,1] = this.gameObject.transform.GetChild(2).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[0,2] = this.gameObject.transform.GetChild(3).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[1,0] = this.gameObject.transform.GetChild(4).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[1,1] = this.gameObject.transform.GetChild(5).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[1,2] = this.gameObject.transform.GetChild(6).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[2,0] = this.gameObject.transform.GetChild(7).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[2,1] = this.gameObject.transform.GetChild(8).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[2,2] = this.gameObject.transform.GetChild(9).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
	}

	bool CheckRecipe()
	{
		for(int i = 0; i < recipenum; i++)
		{
			if(Materials == Recipes[i])
			{
				return true;
			}
		}
		return false;
	}
}
