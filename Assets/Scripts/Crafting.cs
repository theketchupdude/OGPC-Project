using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    CraftingCollider[,] Materials = new CraftingCollider[3, 3];

    List<string[,]> Recipes = new List<string[,]>();
    public List<GameObject> Results = new List<GameObject>();

    public bool craft = false;

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

        CreateRecipe(new string[,] {
            {"Coconut", "Coconut", "Coconut"},
            {"Coconut", "Coconut", "Coconut"},
            {"Coconut", "Coconut", "Coconut"}
        });
    }

    public void Update()
    {
        UpdateMaterials();
        int recipe = CheckRecipe();

        if (recipe != -1 && craft)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameObject currentObject = Materials[i, j].GetCraftingMaterialObject();
                    Destroy(currentObject);
                    Materials[i, j].TriggerExit();
                }
            }
            Instantiate(Results[recipe], new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2, gameObject.transform.position.z), Quaternion.identity);
            recipe = -1;
        }
    }

    void CreateRecipe(string[,] recipe)
    {
        Recipes.Add(recipe);
    }

    void UpdateMaterials()
    {
        int index = 1;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Materials[i, j] = gameObject.transform.GetChild(index).gameObject.GetComponent<CraftingCollider>();
                index++;
            }
        }
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

    bool ArrayContentEquals(string[,] array1, CraftingCollider[,] array2, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array1[i, j] != array2[i, j].GetCraftingMaterial())
                {
                    return false;
                }
            }
        }
        return true;
    }
}
