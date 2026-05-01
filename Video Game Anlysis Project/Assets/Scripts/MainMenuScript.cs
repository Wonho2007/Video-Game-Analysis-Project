using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void loadInfo()
    {
        SceneManager.LoadScene("Info");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Title");
    }


}
