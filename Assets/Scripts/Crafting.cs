using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    string[,] Materials = new string[3, 3];

    List<string[,]> Recipes = new List<string[,]>();
    public List<GameObject> Results = new List<GameObject>();

    void Start()
    {
        CreateRecipe(new string[,] {
            {"none", "none", "none"},
            {"none", "Flint", "none"},
            {"none", "Stick", "none"}
        });

        CreateRecipe(new string[,] {
            {"none", "Flint", "none"},
            {"none", "Flint", "none"},
            {"none", "Stick", "none"}
        });
	}

    public void UpdateRecipe()
    {
        UpdateMaterials();

        int recipe = CheckRecipe();

        if (recipe != -1)
        {
            Debug.Log("Recipe crafted");
            Instantiate(Results[recipe], new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 20, gameObject.transform.position.z), Quaternion.identity);
        }
    }

    void CreateRecipe(string[,] recipe)
    {
        Recipes.Add(recipe);
    }

    void UpdateMaterials()
    {
        Materials[0, 0] = gameObject.transform.GetChild(1).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
        Materials[0, 1] = gameObject.transform.GetChild(2).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
        Materials[0, 2] = gameObject.transform.GetChild(3).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
        Materials[1, 0] = gameObject.transform.GetChild(4).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
        Materials[1, 1] = gameObject.transform.GetChild(5).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
        Materials[1, 2] = gameObject.transform.GetChild(6).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
        Materials[2, 0] = gameObject.transform.GetChild(7).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
        Materials[2, 1] = gameObject.transform.GetChild(8).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
        Materials[2, 2] = gameObject.transform.GetChild(9).gameObject.GetComponent<CraftingCollider>().GetCraftingMaterial();
    }

    int CheckRecipe()
    {
        for (int i = 0; i < Recipes.Count; i++)
        {
            if (ArrayContentEquals(Recipes[i], Materials, 3, 3))
            {
                return i;
            }
        }
        return -1;
    }

    bool ArrayContentEquals(string[,] array1, string[,] array2, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array1[i, j] != array2[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
