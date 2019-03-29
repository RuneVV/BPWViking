using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtRewardAlgiz : MonoBehaviour
{

    public GameObject AlgizArt;
    public GameObject AlgizRuneModel;

    public float pickup = 1f;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            pickup = 2f;
            GetComponent<AudioSource>().Play();
            AlgizArt.GetComponent<Image>().enabled = true;
            AlgizRuneModel.SetActive(false);
        }
    }
}
