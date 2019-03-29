using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target4 : MonoBehaviour
{
    public float health = 90f;
    public float hasDied4 = 1f;

   

    

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 10f)
        {
            GetComponent<AudioSource>().Play();
        }

        if (health <= 0f)
        {

            hasDied4 = 2f;
            FindObjectOfType<GetReward>().SpawnRune4();
            Die();
        }
    }


    public void Die()
    {
        
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}


