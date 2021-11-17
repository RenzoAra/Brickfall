using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject pared1;
    public GameObject pared2;
    public GameObject piso1;
    public GameObject piso2;
    public GameObject player;
    public GameObject txtmonedas;
    public GameObject ladrillo;
    public GameObject moneda;
    public GameObject vidaExtra;
    // Next update in second
    private int nextUpdate=1;
    private int probabilidad;
    public int dificulty = 0;
    public int incremento = 1;
    

    private void Awake()
    {
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Ladrillo").SetActive(true);
        GameObject.FindWithTag("Coin").SetActive(true);
        GameObject.FindWithTag("ShieldPowerUp").SetActive(true);
        GameObject.FindWithTag("ExtraLife").SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            txtmonedas.SetActive(false);
            //Destroy(player);
            //Destroy(pared1);
            //Destroy(pared2);
            //Destroy(piso1);
            //Destroy(piso2);
            //GameObject.FindWithTag("Player").SetActive(false);
            GameObject.FindWithTag("Piso").SetActive(false);
            GameObject.FindWithTag("Ladrillo").SetActive(false);
            GameObject.FindWithTag("Coin").SetActive(false);
            //GameObject.FindWithTag("ShieldPowerUp").SetActive(false);
            GameObject.FindWithTag("ExtraLife").SetActive(false);
        }
     
        // If the next update is reached
        if(Time.time>=nextUpdate){
            //Debug.Log(Time.time+">="+nextUpdate);
            // Change the next update (current second+1)
            nextUpdate=Mathf.FloorToInt(Time.time)+1;
            // Call your fonction
            dificulty++;
            if(dificulty == 5 && incremento < 10){
                incremento++;
                dificulty = 0;
            }
            for(int i = 0; i < incremento; i++){
                probabilidad = Random.Range(0, 100);
                Instanciar(probabilidad);       
            }
            
        }

    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

         
     // Update is called once per second
    public void Instanciar(int probabilidad){
        if(probabilidad<=70){
            GameObject brick = Instantiate(ladrillo);
            brick.transform.position = new Vector3(Random.Range(-50, 50), 37, 0);
        }
        if(probabilidad>70 && probabilidad<=90){
            GameObject coin = Instantiate(moneda);
            coin.transform.position = new Vector3(Random.Range(-50, 50), 37, 0);
        }
        if(probabilidad>90 && probabilidad<=100){
            GameObject extralife = Instantiate(vidaExtra);
            extralife.transform.position = new Vector3(Random.Range(-50, 50), 37, 0);
        }
     }
}
