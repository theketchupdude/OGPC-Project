using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	
	public int health = 100;
	public int hunger = 0;

    [SerializeField]
    float HungerRate = 1;
	
	private Image screentint;
	
	// Use this for initialization
	void Start () 
    {
		screentint = GameObject.Find("Tint").GetComponent<Image>();
		
		InvokeRepeating("DecrementHunger", HungerRate, HungerRate);
	}
	
	// Update is called once per frame
	void Update () 
    {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.position = transform.position + Camera.main.transform.forward * z;

        screentint.color = new Color(1, 0, 0, -(health/100.0f) + 1.0f);
	}
	
	void DecrementHunger()
	{
		if(hunger != 0)
		{
			hunger -= 1;
			health += 1;
		}
		else if(health != 0)
		{
			health -= 1;
		}
		else
		{
			SceneManager.LoadScene(1);
		}
	}
	
	void OnCollisionEnter(Collision collision) 
    {
		if(collision.gameObject.tag == "Food")
		{
			hunger += 25;
			Destroy(collision.gameObject);
		}
	}
}
