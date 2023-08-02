using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public bool gameOverIsActive = false;
    public GameObject mercy;
    string highScoreKey = "High Score";

    [ContextMenu("Increase Score")]

    public void addScore(int scoreToAdd) {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        if (this.playerScore > PlayerPrefs.GetInt(highScoreKey))
        {
            PlayerPrefs.SetInt(highScoreKey, this.playerScore);
            highScoreText.text = PlayerPrefs.GetInt(highScoreKey).ToString();
        }
        gameOverScreen.SetActive(true);
        gameOverIsActive = true;
    }

    private void Start()
    {
        PlayerPrefs.GetInt(highScoreKey, 0);
        highScoreText.text = PlayerPrefs.GetInt(highScoreKey).ToString();
    }
}
