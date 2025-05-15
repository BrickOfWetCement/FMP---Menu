using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToMenu : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Main Menu");


    }
    public void QuitGame()
    {
        Application.Quit();


    }
}
