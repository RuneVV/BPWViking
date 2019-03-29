using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarChecker : MonoBehaviour
{
    public GameObject targetPillar;
    public bool hasCorrectPillar = false;
    public PillarCheckerChecker checker;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Pillar>() != null){
            if(targetPillar == col.gameObject)
            {
                hasCorrectPillar = true;
                GetComponent<AudioSource>().Play();
            }
            else
            {
                hasCorrectPillar = false;
            }
            checker.CheckAllPillarCheckers();
        }

    }
}
