using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject GameOver;
    [ContextMenu("Increase the score")]
    public void addScore()
    {
         playerscore += 1;
         scoreText.text = playerscore.ToString();
    }

    public int flaps;
    public Text Flaptext;
    [ContextMenu("Flap")]
    public void nflaps()
    {
        flaps += 1;
        Flaptext.text = flaps.ToString();    
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void dead(){
        GameOver.SetActive(true);
    }
}
