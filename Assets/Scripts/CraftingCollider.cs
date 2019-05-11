using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingCollider : MonoBehaviour
{
    string craftingMaterial = "none";
    GameObject materialReference = null;

    void OnTriggerEnter(Collider collision)
    {
        materialReference = collision.gameObject;
        craftingMaterial = collision.gameObject.name;
    }

    void OnTriggerExit(Collider collision)
    {
        TriggerExit();
    }

    public string GetCraftingMaterial()
    {
        return craftingMaterial;
    }

    public GameObject GetCraftingMaterialObject()
    {
        return materialReference;
    }

    public void TriggerExit()
    {
        materialReference = null;
        craftingMaterial = "none";
    }
}
