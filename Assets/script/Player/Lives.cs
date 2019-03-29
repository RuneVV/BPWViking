using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lives : MonoBehaviour
{
    public Image HealthIcon;
    public Sprite[] Sprites;

    public float MLives;
    public float Countdown = 5f;
    
    public float seconds = 1f;

    
    public GameObject Lives2;
    public GameObject Lives1;
    public GameObject Lives0;
    public GameObject gameOver;

    public GameObject popup1;
    public GameObject popup2;
    public GameObject introScreen;

    public bool hasPoppedUp1 = false;
    public bool hasPoppedUp2 = false;
    

    private void Start()
    {
        Debug.Log(GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().MagniLives);
        MLives = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().MagniLives;

        introScreen.GetComponent<Image>().enabled = true;
        if (Input.GetKeyDown(KeyCode.E))
        {

            introScreen.GetComponent<Image>().enabled = false;
        }
    }

    //GameObject.Find("Game Manager").GetComponent<GameManager>().MagniLives;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            introScreen.GetComponent<Image>().enabled = false;
        }


        if (MLives == 0f)
        {
            Countdown -= Time.deltaTime;
           
        }

        if (Countdown <= 0f)
        {
            gameOver.GetComponent<Image>().enabled = false;
            
        }

        if ( MLives == 2f)
        {
            popup1.GetComponent<Image>().enabled = true;
            
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                popup1.GetComponent<Image>().enabled = false;
                hasPoppedUp1 = true;
               
            }

            if (hasPoppedUp1 == true)
            {
                popup1.GetComponent<Image>().enabled = false;
            }
        }

        if (MLives == 1f)
        {
            
            popup2.GetComponent<Image>().enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasPoppedUp2 = true;
                popup2.GetComponent<Image>().enabled = false;

            }

            if (hasPoppedUp2 == true)
            {
                popup2.GetComponent<Image>().enabled = false;
            }
        }

    }

    public void LoseLife()
    {
        MLives = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().MagniLives;

        if (MLives == 3)
        {
            
           
            Debug.Log("3 Levens");
            
        }
        else if (MLives == 2)
        {
           
            Debug.Log("2 levens");
            Lives2.GetComponent<Image>().enabled = true;

                  

            

        } else if (MLives == 1)
        {
            
            Debug.Log("1 leven");
            Lives1.GetComponent<Image>().enabled = true;

            
        } else if (MLives == 0)
        {
            Debug.Log("0 Levens");
            Lives0.GetComponent<Image>().enabled = true;
            Debug.Log("GameOver");
            gameOver.GetComponent<Image>().enabled = true;

        }
       // else if (MLives == 0)
       // {
       //     Debug.Log("GameOver");
       //     gameOver.GetComponent<Image>().enabled = true;
            
        //}

        
    }

   

}
