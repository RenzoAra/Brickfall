using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D MyRb;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        MyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MyRb.velocity = new Vector2(0, +Speed);
        Destroy(gameObject, 5f);
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LimiteInferior")
        {
            Destroy(gameObject);
        }
    }
}
