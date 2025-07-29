using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject point;
    public GameObject death;
    private float timer = 0f;
    private float spawnInterval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime*Random.Range(0.5f,2f);
        if (timer >= spawnInterval)
        {
            timer = 0f;
            float r = Random.Range(-8f, 8f);
            float R = Random.Range(-8f, 8f);
            int n=Random.Range(0, 10);
            if (n !=9) 
            Instantiate(point, new Vector2(r, transform.position.y), Quaternion.identity);
            else
            Instantiate(death, new Vector2(R, transform.position.y), Quaternion.identity);
        }
    }
}
