using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroneerController : MonoBehaviour
{
    bool canJump;

    void Start()
    {

    }

    void Update()
    {
        
        /*
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-50f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
        }*/


        if (Input.GetKey("left") | Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-0f * Time.deltaTime, 0));
        }

        if (Input.GetKey("right") | Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f * Time.deltaTime, 0));
        }

        if (Input.GetKeyDown("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 25f));
        }

        if (Input.GetKeyDown("down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -200f));
        }

        if (Input.GetKeyDown("w"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 25f));
        }

        if (Input.GetKeyDown("s"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -200f));
        }
    }
}
