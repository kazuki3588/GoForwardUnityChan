using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    float speed = -12;
    float deadLine = -10;
    public static CubeController instance;
    void Update()
    {
       
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }
   
    private void OnCollisionEnter2D(Collision2D other)
    {
   
        if (other.collider.tag == "Ground" || other.collider.tag == "Cube")
        {
            GetComponent<AudioSource>().Play();
        }
     
    }
    


}
