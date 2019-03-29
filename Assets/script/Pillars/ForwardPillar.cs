using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPillar : MonoBehaviour
{
    public bool pillar1Collide = false;
    public bool trigger1Activated = false;
    public bool pillarMoving = false;


    public float thrust = 10f;
    public float decrease = 0f;
    public Rigidbody rb;

    public GameObject trigger1;
    public GameObject pillar1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (pillar1Collide == true)
        {
            MovePillar();
        }

    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            pillar1Collide = true;


        }

        if (col.gameObject.name == "trigger 3 smallest")
        {
            trigger1Activated = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        pillar1Collide = false;
        rb.velocity = Vector3.zero;
    }

    public void MovePillar()
    {
        rb.AddForce(transform.forward * thrust);



    }


}
