using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int probability;
    // Start is called before the first frame update
    void Start()
    {
        
        //StartCoroutine("instanciar");
        //Debug.Log(probability);
    }

    // Update is called once per frame
    void Update()
    {
        //probability = Random.Range(0, 100);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "LimiteInferior")
        {
            Destroy(gameObject);
        }
    }

    IEnumerator instanciar()
    {
        yield return new WaitForSeconds(1);
        //if(probability <= 50){
            GameObject moneda = Instantiate(gameObject);
            moneda.transform.position = new Vector3(Random.Range(-50, 50), 37, 0);
            //Instantiate(gameObject).transform.position = new Vector3(Random.Range(-27,27), 30, 0);
        //}
    }
}
