using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float MagniLives = 3f;
    public float Countdown = 5f;
    public float seconds = 1f;
    public GameObject Player; 
    public void EndGame()
    {
        
        if (gameHasEnded == false) ;
        {

        }
        gameHasEnded = true;
        MagniLives = MagniLives - 1;
        Debug.Log(MagniLives);
        Debug.Log("The cold grasp of Hel draws closer");
        FindObjectOfType<Lives>().LoseLife();
        Player.transform.position = new Vector3(230, 76, -4.76f);

              
    }

    public void Update()
    {
        if (MagniLives <= 0f)
        {
            Countdown -= Time.deltaTime;
            if (Countdown < 0)
            {
                Restart();
            }

        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("NEXT");
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       SceneManager.LoadScene(1);

    }
}
