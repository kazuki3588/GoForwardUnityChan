using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    bool blockAudio = false;
    float speed = -12;
    float deadLine = -10;
    public static CubeController instance;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
        GetComponent<AudioSource>().volume = (blockAudio) ? 1 : 0;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {
            blockAudio = false;
        }
        else if (other.collider.tag == "Ground" || other.collider.tag == "Cube")
        {
            blockAudio = true;
        }
     
    }

}
