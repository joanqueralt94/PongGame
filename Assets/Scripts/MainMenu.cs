using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Method wich Load Player vs AI game mode
    public void PlayerVSAI()
    {
        SceneManager.LoadScene("PlayerVSAI");
    }

    //Method wich Load Player vs Player game mode
    public void PlayerVSPlayer()
    {
        SceneManager.LoadScene("PlayerVSPlayer");
    }

    //Method wich Load Main Menu scene
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Method wich the player can exit the game on build
    public void QuitGame() => Application.Quit();

}








