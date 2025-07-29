using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    public GameObject box;
    public float speed = 100;
    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {   //movement
        if (Input.GetKey(KeyCode.A) && box.transform.position.x> -8f)
            box.transform.Translate(Vector2.left*speed*Time.deltaTime);
        if (Input.GetKey(KeyCode.D) && box.transform.position.x<8f)
            box.transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("death"))

        {
            Destroy(box);
            logic.Gameover();
        }
        if(collision.CompareTag("point"))
            logic.addScore();
    }
}
