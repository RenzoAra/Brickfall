using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("instanciar");
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
        Destroy(gameObject);
    }

    IEnumerator instanciar()
    {
        yield return new WaitForSeconds(1);
        Instantiate(gameObject).transform.position = new Vector3(Random.Range(-27,27), 30, 0);
    }
}
