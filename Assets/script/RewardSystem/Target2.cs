
using UnityEngine;

public class Target2 : MonoBehaviour
{
    public float health = 80f;
    public float hasDied2 = 1f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 10f)
        {
            GetComponent<AudioSource>().Play();
        }

        if (health <= 0f)
        {

            hasDied2 = 2f;
            FindObjectOfType<GetReward>().SpawnRune2();
            Die();
        }
    }

    public void Die()
    {

        gameObject.SetActive(false);
        //Destroy(gameObject);
    }


}
