using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{

    public int playerScore;
    public Text scoreTextObject;
    public GameObject gameOverScreen;

    [ContextMenu("Increse Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreTextObject.text = playerScore.ToString();
    }

    public void restartGame() {

        Debug.Log(SceneManager.GetActiveScene().name);
        //await SceneManager.UnloadSceneAsync(Scenes.SampleScene);
        SceneManager.LoadScene(Scenes.SampleScene);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


    public void showGameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
