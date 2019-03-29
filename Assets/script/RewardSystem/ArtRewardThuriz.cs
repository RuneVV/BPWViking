using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtRewardThuriz : MonoBehaviour
{

    public GameObject ThurizArt;
    public GameObject ThurizRuneModel;

    CharacterStats myStats;

    public float pickup = 1f;

    public void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            pickup = 2f;
            
            ThurizArt.GetComponent<Image>().enabled = true;
            GetComponent<AudioSource>().Play();
            ThurizRuneModel.SetActive(false);
        }
    }

   
}