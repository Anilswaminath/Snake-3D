using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject preBody;
	private GameObject[] bodies;
	private float timer = 0f;
	private Vector3 forward = Vector3.forward;
	bool left, right, up, down;
	public int count;
	public bool isDead = false;
	private AudioSource eatSound;
	public Material red;
	public Material blue;

	void Start () 
	{
		bodies = new GameObject[1000];
		bodies [0] = gameObject;
		bodies [1] = preBody;
		count = 2;
		eatSound = gameObject.GetComponent<AudioSource> ();
	}
	void Update () 
	{
		forward = currentForward();
		timer += Time.deltaTime;
		if (timer > 0.1f)
		{
			followHead ();
			transform.position += forward;
			timer = 0f;
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Food")
		{
			if(other.gameObject.name == "Red")
			{
				
				ScoreStreak.RedScoreStreak();
				ScoreSystem.AddScoreRed();
				ScoreStreak.blueStreak = 0;
				Growred();
			}
			if(other.gameObject.name == "Blue")
			{
				ScoreStreak.BlueScoreStreak();
				ScoreSystem.AddScoreBlue();
				ScoreStreak.redStreak = 0;
				Growblue();
			}
			eatSound.Play ();
		}
		if (other.gameObject.tag == "Wall") 
		{
			transform.position = preBody.transform.position;
			forward = Vector3.zero;
			isDead = true;
		}
		if (other.gameObject.tag == "Body")
		{
			transform.position = preBody.transform.position;
			forward = Vector3.zero;
			isDead = true;
		}
	}
	Vector3 currentForward()
	{
		if (Input.GetKeyDown(KeyCode.W) && !down)
		{
			up = true;
			left = false;
			right = false;
			return Vector3.forward;
		}
		else if (Input.GetKeyDown(KeyCode.S) && !up)
		{
			down = true;
			left = false;
			right = false;
			return Vector3.back;
		}
		else if (Input.GetKeyDown(KeyCode.A) && !right)
		{
			up = false;
			down = false;
			left = true;
			return Vector3.left;
		}
		else if (Input.GetKeyDown(KeyCode.D) && !left)
		{
			up = false;
			down = false;
			right = true;
			return Vector3.right;
		}
		else
		{
			return forward;
		}
	}
	void followHead() 
	{
		if (!isDead) 
		{
			for (int i = count - 1; i > 0; i--) 
			{
				bodies [i].transform.position = bodies [i - 1].transform.position;
			}
		}
	}
	void Growred() 
	{
		GameObject newBody = GameObject.Instantiate (preBody);
		var cubeRenderer = newBody.GetComponent<Renderer>();
		cubeRenderer.material.SetColor("_Color", Color.red);
		bodies [count] = newBody;
		count++;
	}
	void Growblue() 
	{
		GameObject newBody = GameObject.Instantiate (preBody);
		var cubeRenderer = newBody.GetComponent<Renderer>();
		cubeRenderer.material.SetColor("_Color", Color.blue);
		bodies [count] = newBody;
		count++;
	}
}
