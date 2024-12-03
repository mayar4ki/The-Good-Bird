using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{

    public int playerScore;
    public Text scoreTextObject;
    public GameObject gameOverScreen;
    public GameObject gamePauseScreen;
    public GameObject pauseButton;


    [ContextMenu("Increse Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreTextObject.text = playerScore.ToString();
    }

    public void restartGame() {


        SceneManager.LoadScene(Scenes.SampleScene);
    }

    public void showGameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void toggleGamePause ()
    {
        bool isPaused = Time.timeScale == 0;
        Time.timeScale = isPaused ? 1 : 0;
        gamePauseScreen.SetActive(!isPaused);
        pauseButton.SetActive(isPaused);
    }

    public void backToStartMenu()
    {
            SceneManager.LoadScene(Scenes.StartMenuScene);
    }

        // Update is called once per frame
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggleGamePause();
        }
    }
}
