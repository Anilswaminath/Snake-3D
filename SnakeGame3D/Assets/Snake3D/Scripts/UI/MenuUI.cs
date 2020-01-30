using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
   public void StartScene ()
    {
        SceneManager.LoadScene("MainScene");
    } 
    public void GameScene ()
    {
        SceneManager.LoadScene("Snake");
    }
}
