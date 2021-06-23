using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGnerator : MonoBehaviour
{
    public GameObject cubePrefab;
    float delta = 0;
    float span = 1.0f;
    float genPosX = 12;
    float offsetY = 0.3f;
    float spaceY = 6.9f;
    float offsetX = 0.5f;
    float spaceX = 0.4f;
    int maxBlockNum = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            int n = Random.Range(1, maxBlockNum + 1);
            for(int i = 0; i <n; i++)
            {
                GameObject go = Instantiate(cubePrefab);
                go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
            }
            this.span = this.offsetX + this.spaceX * n;
        }
    }
}
