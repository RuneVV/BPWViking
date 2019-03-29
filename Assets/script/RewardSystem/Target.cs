
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 70f;
    public float hasDied = 1f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 10f)
        {
            GetComponent<AudioSource>().Play();
        }

        if (health <= 0f)
        {
            hasDied = 2f;
            FindObjectOfType<GetReward>().SpawnRune();
            Die();
        }
    }
    
    public void Die()
    {
        
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }

  
}
