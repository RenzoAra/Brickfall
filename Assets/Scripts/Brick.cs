using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine("instanciar");
        this.GetComponent<Rigidbody2D>().gravityScale = Random.Range(3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (gameObject.transform.position.y <= 2)
        {
            Destroy(gameObject);
        }*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player" | collision.transform.tag == "Piso" | collision.transform.tag == "LimiteInferior" | collision.transform.tag == "Coin" | collision.transform.tag == "ExtraLife")
        {
            Destroy(gameObject);
            //PlayerManager.ladrillo = gameObject;
            //gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            Destroy(gameObject);
            //PlayerManager.ladrillo = gameObject;
            //gameObject.SetActive(false);
        }
    }

    IEnumerator instanciar()
    {
        yield return new WaitForSeconds(1);
        GameObject brick = Instantiate(gameObject);
        brick.transform.position = new Vector3(Random.Range(-50, 50), 37, 0);
        //Instantiate(gameObject).transform.position = new Vector3(Random.Range(-27,27), 30, 0);
    }
}
