using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdieController : MonoBehaviour
{
    bool canJump;
    int jumplimit = 0;

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
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
        }

        if (Input.GetKey("right") | Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
        }

        if (Input.GetKeyDown("up") && canJump)
        {
            jumplimit++;
            if (jumplimit == 2) {
                canJump = false;
                jumplimit = 0;
            }
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300f));
        }

        if (Input.GetKeyDown("down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -200f));
        }

        if (Input.GetKeyDown("w") && canJump)
        {
            jumplimit++;
            if (jumplimit == 2)
            {
                canJump = false;
                jumplimit = 0;
            }
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300f));
        }

        if (Input.GetKeyDown("s"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -200f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Piso")
        {
            canJump = true;
        }
    }
}
