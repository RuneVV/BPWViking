using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target3 : MonoBehaviour
{
    public float health = 90f;
    public float hasDied3 = 1f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 10f)
        {
            GetComponent<AudioSource>().Play();
        }

        if (health <= 0f)
        {
            hasDied3 = 2f;
            FindObjectOfType<GetReward>().SpawnRune3();
            Die();
        }
    }

    public void Die()
    {

        gameObject.SetActive(false);
        //Destroy(gameObject);
    }


}
