using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	public GameObject GameOver;
	public AudioClip deadClip;
	private GameObject snake;
	private PlayerController playerController;
	public AudioSource BGM;
	
	void Start () 
	{
		ScoreStreak.redStreak = 0;
		ScoreStreak.blueStreak = 0;
		ScoreSystem.scoretotal = 0;
		GameOver.SetActive(false);
		snake = GameObject.FindGameObjectWithTag ("Player");
		playerController = snake.GetComponent<PlayerController> ();
	}
	void Update () 
	{
		if (playerController.isDead) 
		{

			if (BGM.isPlaying)
			{
				BGM.Stop();
				AudioSource.PlayClipAtPoint(deadClip, transform.position);
			}
			StartCoroutine(WaitTime());
		}
	}
	IEnumerator WaitTime()
	{
		while(playerController.isDead)
		{
			yield return new WaitForSeconds(1f);
			GameOver.SetActive(true);
		}
	}
}
