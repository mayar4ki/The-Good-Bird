using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public void onPlayClick() {
        SceneManager.LoadScene(Scenes.SampleScene);
    }

    public void onDestroyClick() {
     Application.Quit();
    }

}
