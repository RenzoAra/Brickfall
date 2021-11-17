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
    //Players
    public GameObject Komu;
    public GameObject Birdie;
    public GameObject Astronauta;
    public GameObject FireBall;
    public GameObject IceBall;
    public GameObject Jagguer;
    public GameObject Rocky;

    // Next update in second
    private int nextUpdate=1;
    private int probabilidad;
    public int dificulty = 0;
    public int incremento = 1;
    

    public CharacterDatabase characterDB;
    private int selectedOption = 0;

    private void Awake()
    {
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {

        if(!PlayerPrefs.HasKey("selectedOption")){
            selectedOption = 0;
        }
        else{
            Load();
        }
        UpdateCharacter(selectedOption);


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
        if(probabilidad<=85){
            GameObject brick = Instantiate(ladrillo);
            brick.transform.position = new Vector3(Random.Range(-69, 69), 55, 0);
        }
        if(probabilidad>85 && probabilidad<=90){
            GameObject coin = Instantiate(moneda);
            coin.transform.position = new Vector3(Random.Range(-69, 69), 55, 0);
        }
        if(probabilidad>90 && probabilidad<=91){
            GameObject extralife = Instantiate(vidaExtra);
            extralife.transform.position = new Vector3(Random.Range(-69, 69), 55, 0);
        }
     }

    private void UpdateCharacter(int selectedOption){
        Character character = characterDB.GetCharacter(selectedOption);
        switch(selectedOption){
            case 0:
                Komu.SetActive(true);
                break;
            case 1:
                IceBall.SetActive(true);
                break;
            case 2:
                Birdie.SetActive(true);
                break;
            case 3:
                Jagguer.SetActive(true);
                break;
            case 4:
                FireBall.SetActive(true);
                break;
            case 5:
                Rocky.SetActive(true);
                break;
            case 6:
                Astronauta.SetActive(true);
                break;
        }
    }

    private void Load(){
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
