using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour {
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool isGameActive = true;

    [ContextMenu("addScore")]
    public void addScore(int score) {
        if (isGameActive) {
            playerScore += score;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameActive = true;
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
        isGameActive = false;
    }
}