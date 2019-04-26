using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OVRstuff : MonoBehaviour {

    public int health = 100;
    public int hunger = 0;

    [SerializeField]
    float HungerRate = 1;

    Image screentint;

    // Use this for initialization
    void Start () {
        screentint = GameObject.Find("Tnt").GetComponent<Image>();

        InvokeRepeating("DecrementHunger", HungerRate, HungerRate);
    }

    void DecrementHunger()
    {
        if (hunger != 0)
        {
            hunger -= 1;
            health += 1;
        }
        else if (health != 0)
        {
            health -= 1;
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    // Update is called once per frame
    void Update () {
        screentint.color = new Color(1, 0, 0, -(health / 100.0f) + 1.0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            hunger += 25;
            Destroy(collision.gameObject);
        }
    }
}
