using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    [Tooltip("The score text.")]
    public GameObject scoreUI;


    [Tooltip("The text that shows the player's score.")]
    public Text scoreText;


    void Update()
    {
        // displays the player's current score onto text
        scoreText.text = ("SCORE: " + ScoreManager.score);
       
        

    }
}
  