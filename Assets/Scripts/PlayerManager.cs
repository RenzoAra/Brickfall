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
    

    private void Awake()
    {
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            txtmonedas.SetActive(false);
            Destroy(player);
            Destroy(pared1);
            Destroy(pared2);
            Destroy(piso1);
            Destroy(piso2);
            Destroy(GameObject.FindWithTag("Ladrillo"));
            Destroy(GameObject.FindWithTag("Coin"));
            Destroy(GameObject.FindWithTag("ShieldPowerUp"));
            Destroy(GameObject.FindWithTag("ExtraLife"));
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
}
