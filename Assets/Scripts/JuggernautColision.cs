using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuggernautColision : MonoBehaviour
{
    public int cantidadmonedas;
    public Text txtmonedas;
    public Text txtmonedasfinal;
    public int invincibilityLimit = 0;

    void start(){

    }

    /*void Update()
    {
        txtmonedas.text = "Monedas: " + cantidadmonedas;
        txtmonedasfinal.text = "Monedas: " + cantidadmonedas;
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ladrillo" & JuggernautController.isInvincible == false)
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
        if (invincibilityLimit < 3){
            invincibilityLimit = invincibilityLimit + 1;
        }
        if(invincibilityLimit == 2){
            JuggernautController.isInvincible = false;
            invincibilityLimit = 0;
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
    }
}
