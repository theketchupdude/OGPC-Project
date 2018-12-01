using System;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{

    void Start()
    {
        // Fill each array with a array of GameObjects (Max 'stack' value is subject to change, just arbitrary number for testing).
        for (int i = 0; i < collectedItems.Length; i++)
        {
            collectedItems[i] = new GameObject[8]; // Add one more then you want because of the way arrays work
        }
    }

    // Create a new 'jagged' array (an array of arrays) of GameObjects (Maximum different types of items is subject to change. just arbitrary numbers for testing).
    public GameObject[][] collectedItems = new GameObject[4][]; 

    private void OnCollisionEnter(Collision collision)
    {
        // Check to see if we can pick up the item based on whether it has the "Collectable" tag
        if (collision.gameObject.tag != "Collectable")
        {
            return;
        }

        // Loop through all the items (arrays) in 'collectedItems'.
        for (int i = 0; i < collectedItems.Length; i++)
        {
            // Check to see if the array is null, this should mean that is the first of its kind of object.
            if (collectedItems[i][0] == null)
            {
                Debug.Log("Different Objects (1)");
                collectedItems[i][0] = collision.gameObject;
                break;
            }
            // I'm not sure what is is suppost to do, I had it then changed the code and it never gets run but I don't want to delete it just in case.
            // TODO: This is probobly not needed
            if (i >= collectedItems.Length)
            {
                Debug.Log("Different Object (2)");
                collectedItems[i + 1][0] = collision.gameObject;
            }

            // Check to see if there is already a item of the same type in our 'inventory' based on the name of it (I know it's not the best way but it's the only thing that worked).
            if (collectedItems[i][0].name == collision.gameObject.name)
            {
                int amount = 0;
                for (int j = 0; j < collectedItems[i].Length; j++)
                {
                    if (collectedItems[i][j] != null)
                    {
                        amount++;
                    } 
                }
                Debug.Log("Same object");
                try
                {
                    collectedItems[i][amount] = collision.gameObject;
                } catch (Exception e)
                {
                    Debug.LogError("To many items in the stack");
                    return;
                }
                amount = 0;
                break;
            }
            continue;
        }
        // TODO: Change this
        // This just moves the object up so it disapears, since you can't delete it.
        collision.gameObject.transform.position = new Vector3(0, 100, 0);
    }

    void Update()
    {
        // This is all really for testing purposes i'm not sure if any of this will be helpful later.
        // The code doesn't work anyways without using it with the debugger anyways
        if (Input.GetKeyDown("i"))
        {
            // Making a local variable so I can view the 'jagged' array in the debugger.
            GameObject[][] items = collectedItems;
            // Placeholder so I can put the debugger somewhere.
            int i = 0;
        }
    }
}
