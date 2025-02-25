using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [Header("pltfrm Object")]
        public GameObject platform;
        float yPos = 0;
    [Header("Game Over UI Canvas Object")]
        public GameObject gameOverCanvas;
   public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("DoodleHead").SetActive(false);
        GameController.GameOver();

        


       
    }

    public static void GameOver()
    {
        instance.gameOverCanvas.SetActive(true);
    }
}
