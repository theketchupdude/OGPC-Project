using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour {

    //public float spacing = 5f; // Unused for now, but could be to add spacing in between the trees

    public List<Vector3> treeLocations = new List<Vector3>(); // List of all the locations of the trees
    public GameObject[] trees; // All possible tree models

    public int amountOfTrees = 20; //Number of trees to spawn a.k.a. density

    public Vector3 offset; // Offset of spawn area from game object (see gizmo in inspector)
    public Vector3 size; // Size of spawn area (see gizmo in inspector)

    // Use this for initialization
    void Start()
    {
        // Choose random locations for the trees and add them to the list
        for (int i = 0; i < amountOfTrees; i++)
        {
            treeLocations.Add(transform.localPosition + offset + new Vector3(Random.Range(-size.x / 2, size.x / 2), size.y / 2, Random.Range(-size.x / 2, size.x / 2)));
        }

        // Spawn each tree based on the Vector3's in the list
        foreach (Vector3 location in treeLocations)
        {
            int index = Random.Range(0, trees.Length);
            if (index == 0) {
                // Added offset for different kinds of trees
                Instantiate(trees[index], location + new Vector3(0, 13, 0), Quaternion.Euler(-90, 0, 0));
            } else
            {
                // Added offset for different kinds of trees
                Instantiate(trees[index], location + new Vector3(0, 2, 0), Quaternion.Euler(-90, 0, 0));
            }
        }
    }

    // Drawing gizmo for spawn area representation
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + offset, size);
    }
}
