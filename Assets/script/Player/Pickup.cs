using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public GameObject ButtonE;
    public GameObject myHammer;
    public GameObject myHammerOnGround;

    public GameObject MjolnirGraphic;

    public bool hammerCollide = false; 

    private void Start() //hamer in hand is uit
    {
        myHammer.SetActive(false);
                
    }

    private void Update() //als player met hamer met tag "weapon collide" , hammer collide == true 
    {
       
        pickUpHammer();
    }

   
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            hammerCollide = true;
            ButtonE.GetComponent<Image>().enabled = true;
        }
    }

    
    private void pickUpHammer() //als hammerCollide == true en r wordt ingedrukt dan wordt de hammer 'opgepakt'
    {
        if(hammerCollide == true && Input.GetKeyDown(KeyCode.E))
        {
            myHammer.SetActive(true);
            myHammerOnGround.SetActive(false);
            ButtonE.GetComponent<Image>().enabled = false;
            MjolnirGraphic.GetComponent<Image>().enabled = true;
        }
    }

    // private void OnTriggerStay(Collider objectHammer)
    // {
    //     if(objectHammer.tag == "Weapon" && Input.GetKeyDown("r") )
    //     {
    //        
    //        myHammer.SetActive(true);
    //        myHammerOnGround.SetActive(false);
    //     }
    // }

}
