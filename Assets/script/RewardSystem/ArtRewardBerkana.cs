using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtRewardBerkana : MonoBehaviour
{

    public GameObject BerkanaArt;
    public GameObject BerkanaRuneModel;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {

            GetComponent<AudioSource>().Play();
            BerkanaArt.GetComponent<Image>().enabled = true;
            BerkanaRuneModel.SetActive(false);
        }
    }
}
