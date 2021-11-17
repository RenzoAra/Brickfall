using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackgroundManager : MonoBehaviour
{
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;

    private int selectedBackground = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("selectedBackground")){
            selectedBackground = 0;
        }
        else{
            LoadBackground();
        }
        UpdateBackground(selectedBackground);
    }

    public void NextOption(){
        selectedBackground++;

        if(selectedBackground >= characterDB.CharacterCount){
            selectedBackground = 0;
        }
        UpdateBackground(selectedBackground);
        Save();
    }

    public void BackOption(){
        selectedBackground--;

        if(selectedBackground < 0){
            selectedBackground = characterDB.CharacterCount - 1;
        }
        UpdateBackground(selectedBackground);
        Save();
    }

    private void UpdateBackground(int selectedBackground){
        Character character = characterDB.GetCharacter(selectedBackground);
        artworkSprite.sprite = character.characterSprite;
    }

    private void LoadBackground(){
        selectedBackground = PlayerPrefs.GetInt("selectedBackground");
    }

    private void Save(){
        PlayerPrefs.SetInt("selectedBackground", selectedBackground);
    }

    public void Play(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
