using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public float distance = 4;
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger");
        if (other.gameObject.tag == "Player")
        {
            
            if (isMoving == false)
            {
                Vector3 direction = transform.position - other.transform.position;
                Debug.Log(direction);
                direction = Vector3.Scale(direction, new Vector3(1, 0, 1));
                float dot = Vector3.Dot(direction, transform.forward);

                if( dot > 0.5)
                {
                    GetComponent<AudioSource>().Play();
                    direction = transform.forward;
                    
                }
                else if(dot > -0.5f)
                {
                    if(direction.x > 0)
                    {
                        GetComponent<AudioSource>().Play();
                        direction = transform.right;
                       
                    }
                    else
                    {
                        GetComponent<AudioSource>().Play();
                        direction = -transform.right;
                        
                    }
                }
                else
                {
                    GetComponent<AudioSource>().Play();
                    direction = -transform.forward;
                    
                }


                StartCoroutine(MoveBlock(direction.normalized * distance));
            }
        }
    }

    IEnumerator MoveBlock(Vector3 direction)
    {
        isMoving = true;
        Vector3 startposition = transform.position;
        Vector3 endposition = transform.position + direction;
        float seconds = 1;
        float t = 0;
        while (t < 1)
        {
            transform.position = Vector3.Lerp(startposition, endposition, t);
            t += Time.deltaTime * 1/seconds;
            yield return null;

        }
        transform.position = endposition;
        isMoving = false;
    }
}
