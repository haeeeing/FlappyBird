using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public GameObject gameOverScreen;
    private bool isGameOver = false;

    private void Start()
    {
        Time.timeScale = 1;
        gameOverScreen.SetActive(false);
        scoreText.text = "Score: 0";
    }

    public void IncreaseScore()
    {
        if(!isGameOver)
        {
            score++;
            scoreText.text = "Score: " + score;
        }
    }

    public void GameOver()
    {
        isGameOver = true; 
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }

}
