using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Food : MonoBehaviour 
{
	public static Food instance;
	public GameObject[] food;
	
	private void Start()
	{
		food[0].name = "Red";
		food[1].name = "Blue";
;	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			randomPosition();
			Destroy (gameObject);
		}
	}
	void randomPosition() {
		GameObject newFood = GameObject.Instantiate(food[UnityEngine.Random.Range(0,food.Length)]);
		float x = Random.Range(-27.5f, 27.5f);
		float z = Random.Range (-27.5f, 27.5f);
		newFood.transform.position = new Vector3 (x, 0.5f, z);
	}
}
