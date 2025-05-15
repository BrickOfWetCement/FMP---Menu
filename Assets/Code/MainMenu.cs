using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Character Select");


    }
    public void QuitGame()
    {
        Application.Quit();


    }
}
