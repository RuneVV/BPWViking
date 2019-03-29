using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get;  set; }


    public GameObject magni100;
    public GameObject magni75;
    public GameObject magni25;

    public Image healthBar;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage (int damage)
    {
        currentHealth -= damage;

        healthBar.fillAmount = currentHealth / 100f;

        if (currentHealth == 100 && currentHealth > 75)
        {
            //Debug.Log("magniIconFull");
            magni100.GetComponent<Image>().enabled = true;
        }
        else if (currentHealth <75 && currentHealth > 25) {

           // Debug.Log("magniIconHalf");
            magni100.GetComponent<Image>().enabled = false;
            magni75.GetComponent<Image>().enabled = true;


        }
        else if ( currentHealth < 25)
        {
            //Debug.Log("magniQuarterHealth");
            magni75.GetComponent<Image>().enabled = false;
            magni25.GetComponent<Image>().enabled = true;
        }

        Debug.Log(transform.name + "takes " + damage + "damage.");

        if (currentHealth <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
            currentHealth = maxHealth;
            healthBar.fillAmount = maxHealth;
            magni25.GetComponent<Image>().enabled = false;
            magni100.GetComponent<Image>().enabled = true;
        }
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.T)){
       //     TakeDamage(10);
       // }
    }
}
