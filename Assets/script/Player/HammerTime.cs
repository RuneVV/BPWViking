using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.LightningBolt;

public class HammerTime : MonoBehaviour
{

    public Animator anim;
    

    public float damage = 10f;
    public float range = 100f;

    public AudioClip Electricity;

    public Camera fpsCam;

    public float attackSpeed = 5f;
    private float attackCooldown = 0f;
    private LightningBoltScript lightningBoltScript;
    // Start is called before the first frame update
    void Start()
    {
        lightningBoltScript = GetComponentInChildren<LightningBoltScript>();
        lightningBoltScript.ManualMode = true;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          attackCooldown -= Time.deltaTime;
       
        if (Input.GetMouseButtonDown(0) && attackCooldown <= 0f)
        {
            anim.SetTrigger("attack");

            Shoot();

            attackCooldown = attackSpeed;
                  
        }
       
    }

    

    void Shoot()
    {
        
        lightningBoltScript.Trigger();
        AudioSource.PlayClipAtPoint(Electricity, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            Target2 target2 = hit.transform.GetComponent<Target2>();
            Target3 target3 = hit.transform.GetComponent<Target3>();
            Target4 target4 = hit.transform.GetComponent<Target4>();
            if (target != null)
            {
                target.TakeDamage(damage);
                GetComponent<AudioSource>().Play();
            }

            if (target2 != null)
            {
                target2.TakeDamage(damage);
                GetComponent<AudioSource>().Play();
            }

            if (target3 != null)
            {
                target3.TakeDamage(damage);
                GetComponent<AudioSource>().Play();
            }

            if (target4 != null)
            {
                target4.TakeDamage(damage);
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
