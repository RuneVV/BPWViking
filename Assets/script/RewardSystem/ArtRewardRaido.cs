using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtRewardRaido : MonoBehaviour
{
    public GameObject RaidoArt;
    public GameObject RaidoRuneModel;
    public GameObject Message;

    public GameObject GapBridger;

    public bool HasTriggered = false;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {

            GetComponent<AudioSource>().Play();
            RaidoArt.GetComponent<Image>().enabled = true;
            RaidoRuneModel.SetActive(false);
            GapBridger.SetActive(true);
            HasTriggered = true;

           

            


        }
    }

   
}
