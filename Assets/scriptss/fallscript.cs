using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fallscript : MonoBehaviour
{

    public float fallSpeed = 25;
    private float deadzone = -7f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + Vector3.down * fallSpeed * Time.deltaTime;

        if (transform.position.y < deadzone)
        {
            Debug.Log("WOOSh!");
            Destroy(gameObject);

        }
    }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Contact!");
                Destroy(gameObject);
            }
        }

    }

