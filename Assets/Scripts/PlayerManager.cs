using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject ladrillo;
    public GameObject pared1;
    public GameObject pared2;
    public GameObject piso1;
    public GameObject piso2;
    public GameObject player;

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
            Destroy(player);
            Destroy(pared1);
            Destroy(pared2);
            Destroy(piso1);
            Destroy(piso2);
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
