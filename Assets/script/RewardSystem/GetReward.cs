using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetReward : MonoBehaviour
{
    //Algiz objects
    public GameObject AlgizRuneModel;
    
    //Berkana objects
    public GameObject BerkanaRuneModel;

    //Raido Objects
    public GameObject RaidoRuneModel;

    //Thuriz Objects
    public GameObject ThurizRuneModel;
    



    
    public float _hasDied;
    public float _hasDied2;
    public float _hasDied3;
    public float _hasDied4;

    
    private void Start()
    {
        
    }



    public void SpawnRune()
    {
        _hasDied = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Target>().hasDied;
       
               
        if (_hasDied == 2f)
        {
            AlgizRuneModel.SetActive(true);
        }
        else 
        {
            AlgizRuneModel.SetActive(false);
        }

        
        
    }

    public void SpawnRune2()
    {
        _hasDied2 = GameObject.FindGameObjectWithTag("Enemy2").GetComponent<Target2>().hasDied2;

        if (_hasDied2 == 2f)
        {
            BerkanaRuneModel.SetActive(true);
        }
        else
        {
            BerkanaRuneModel.SetActive(false);
        }
    }

    public void SpawnRune3()
    {
        _hasDied3 = GameObject.FindGameObjectWithTag("Enemy1").GetComponent<Target3>().hasDied3;

        if (_hasDied3 == 2f)
        {
            RaidoRuneModel.SetActive(true);
        }
        else
        {
            RaidoRuneModel.SetActive(false);
        }
       
    }

    public void SpawnRune4()
    {
        _hasDied4 = GameObject.FindGameObjectWithTag("Enemy4").GetComponent<Target4>().hasDied4;

        if (_hasDied4 == 2f)
        {
            ThurizRuneModel.SetActive(true);


        }
        else
        {
            ThurizRuneModel.SetActive(false);
        }
    }

    

    
}


