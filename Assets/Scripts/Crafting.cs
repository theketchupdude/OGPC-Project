<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Crafting : MonoBehaviour
{
	string[,] Materials = new string[3, 3];
	
	List<string[,]> Recipes = new List<string[,]>();
    List<string> Results = new List<string>();

    void Start () 
	{
        CreateRecipe(new string[,] {
            {"none", "none", "none"}, 
            {"none", "Stick", "none"}, 
            {"none", "Stick", "none"}
        }, "Banana");
	}
	
	public void UpdateRecipe () 
	{
        UpdateMaterials();

        if (CheckRecipe() != -1) {
            Debug.Log("Recipe crafted");
        }
	}
	
	void CreateRecipe(string[,] recipe, string result)
	{
		Recipes.Add(recipe);
        Results.Add(result);
	}
	
	void UpdateMaterials()
	{
		Materials[0,0] = gameObject.transform.GetChild(1).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[0,1] = gameObject.transform.GetChild(2).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[0,2] = gameObject.transform.GetChild(3).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[1,0] = gameObject.transform.GetChild(4).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[1,1] = gameObject.transform.GetChild(5).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[1,2] = gameObject.transform.GetChild(6).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[2,0] = gameObject.transform.GetChild(7).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[2,1] = gameObject.transform.GetChild(8).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
		Materials[2,2] = gameObject.transform.GetChild(9).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
	}

	int CheckRecipe()
	{
		for(int i = 0; i < Recipes.Count; i++)
		{
            if (ArrayContentEquals(Recipes[i], Materials, 3, 3))
			{
                return i;
			}
		}
        return -1;
	}

    bool ArrayContentEquals(string[,] array1, string[,] array2, int rows, int columns) {
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                if (array1[i, j] != array2[i, j]) {
                    return false;
                }
            }
        }
        return true;
    }
}
=======
﻿using System.Collections;
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
>>>>>>> ee2817438609973a023a06543e53f3e4dca22188
