using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UrdWell : MonoBehaviour
{
    public bool wellCollide = false;
    public Sprite[] Sprites;
    public GameObject Book;
    public GameObject ButtonR;
    public GameObject ButtonE;
    public bool bookActive = false;

    private void Update() 
    {

       OpenBook();

        if (bookActive == true && Input.GetKeyDown(KeyCode.E))
        {
            CloseBook();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            wellCollide = true;
            ButtonR.GetComponent<Image>().enabled = true;
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        ButtonR.GetComponent<Image>().enabled = false;
        wellCollide = false; 
    }
    private void OpenBook() 
    {
        if (wellCollide == true && Input.GetKeyDown(KeyCode.R))
        {
            Book.GetComponent<Image>().enabled = true;

            bookActive = true;
            ButtonR.GetComponent<Image>().enabled = false;
            ButtonE.GetComponent<Image>().enabled = true;

        }
    }

    private void CloseBook()
    {
        Book.GetComponent<Image>().enabled = false;
        ButtonE.GetComponent<Image>().enabled = false;
    }
}
