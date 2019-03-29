using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarCheckerChecker : MonoBehaviour
{
    public GameObject bossPrefab;
    public GameObject Rune1;
    public GameObject Rune2;
    public GameObject Rune3;
    public GameObject Rune4;

    

    public PillarChecker[] pillarCheckers;
    private bool bossHasSpawned = false;
    // Start is called before the first frame update
    void Start()
    {
        Rune1.SetActive(false);
        Rune2.SetActive(false);
        Rune3.SetActive(false);
        Rune4.SetActive(false);
        
    }

    public void CheckAllPillarCheckers()
    {
        if (bossHasSpawned)
        {
            return;
        }
        bool spawnBoss = true;
        foreach (PillarChecker pillarChecker in pillarCheckers)
        {
            spawnBoss &= pillarChecker.hasCorrectPillar;
        }
        if (spawnBoss){
            bossHasSpawned = true;
            Instantiate(bossPrefab);
            Rune1.SetActive(true);
            Rune2.SetActive(true);
            Rune3.SetActive(true);
            Rune4.SetActive(true);
            
        }
    }
}
