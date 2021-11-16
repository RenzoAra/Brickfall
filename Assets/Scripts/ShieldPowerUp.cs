using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : MonoBehaviour
{
    public int probability;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("instanciar");
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
        //probability = Random.Range(0, 100);
        //if(probability <= 20){
            GameObject shield = Instantiate(gameObject);
            shield.transform.position = new Vector3(Random.Range(-50, 50), 37, 0);
            //Instantiate(gameObject).transform.position = new Vector3(Random.Range(-27,27), 30, 0);
        //}
        
    }
}
