using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterStats))]
public class EnemyCombat : MonoBehaviour
{
    public float attackSpeed = 5f;
    private float attackCooldown = 0f;
    public int Damage = 5;
    CharacterStats myStats;

    



    private void Start()
    {
        myStats = GetComponent<CharacterStats>();
       
    }

    private void Update()
    {
        attackCooldown -= Time.deltaTime;
    }

    public void Attack( CharacterStats targetStats)

    {
        if (attackCooldown <= 0f)
        {

            targetStats.TakeDamage(Damage);


            attackCooldown = 4f;
        }
        

    }
}
