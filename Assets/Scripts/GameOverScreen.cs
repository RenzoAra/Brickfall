using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class GameOverScript : MonoBehaviour{

    public UnityEngine.UI.Text pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }
}

