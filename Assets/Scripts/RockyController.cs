using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockyController : MonoBehaviour
{
    bool canJump;
    int jumplimit;
    // Start is called before the first frame update
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
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1500f));
        }

        if (Input.GetKeyDown("down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -700f));
        }

        if (Input.GetKeyDown("w") && canJump)
        {
            jumplimit++;
            if (jumplimit == 2)
            {
                canJump = false;
                jumplimit = 0;
            }
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1500f));
        }

        if (Input.GetKeyDown("s"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -700f));
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
