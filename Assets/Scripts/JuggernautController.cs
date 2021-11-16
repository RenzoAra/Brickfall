using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuggernautController : MonoBehaviour
{

    public bool canJump;
    public static bool isInvincible = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 400f));
        }

        if (Input.GetKeyDown("down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -200f));
        }

        if (Input.GetKeyDown("w") && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 400f));
        }

        if (Input.GetKeyDown("s"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -200f));
        }

        if (Input.GetKeyDown("e"))
        {
            isInvincible = true;
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

