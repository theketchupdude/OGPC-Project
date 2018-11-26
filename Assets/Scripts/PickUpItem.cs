using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{

    void Start()
    {

    }

    public GameObject[] collectedItems = new GameObject[16];
    int index = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            collectedItems[index] = collision.gameObject;
            index++;
            collision.gameObject.transform.position += new Vector3(0, 100, 0);
        }
    }

    void Update()
    {
        if (collectedItems == null)
        {
            return;
        }

        string output = "Collected Items: ";
        for (int i = 0; i < collectedItems.Length - 1; i++)
        {
            output += collectedItems[i] + " ";
        }
        Debug.Log(output);
    }
}
