using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColision : MonoBehaviour
{
    public int cantidadmonedas;
    public Text txtmonedas;
    public Text txtmonedasfinal;
    public GameObject shield;
    public int vidas;

    void Update()
    {
        txtmonedas.text = "Monedas: " + cantidadmonedas;
        txtmonedasfinal.text = "Monedas: " + cantidadmonedas;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ladrillo")
        {
            vidas--;
            if(vidas == 0){
                PlayerManager.isGameOver = true;
                gameObject.SetActive(false);
            }
            
        }
        if (collision.transform.tag == "LimiteInferior")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            cantidadmonedas++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "ShieldPowerUp")
        {
            shield.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "ExtraLife")
        {
            vidas++;
            Destroy(collision.gameObject);
        }
    }
}
