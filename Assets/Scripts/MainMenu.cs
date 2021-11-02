using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Play(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Store(){
        SceneManager.LoadScene("Store");
    }
    public void Exit(){
        Application.Quit();
    }
    public void Regresar(){
        SceneManager.LoadScene("MainMenu");
    }
}
