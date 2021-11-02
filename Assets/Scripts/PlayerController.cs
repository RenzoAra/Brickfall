using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canJump;

    void Start(){
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
        }

        ManageJump();
        */

        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
        }

        if (Input.GetKeyDown("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));
        }

        if (Input.GetKeyDown("down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -200f));
        }
    }
    
    /*void ManageJump(){

        if (gameObject.transform.position.y <= 0)
        {
            canJump = true;
        }

        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 10)
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
        }
        else
        {
            canJump = false;

            if(gameObject.transform.position.y > 0)
            {
                gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
            }
        }
    }*/
}
