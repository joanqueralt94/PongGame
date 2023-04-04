using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    void Update()
    {
        
    }

    public void PlayerVSAI()
    {   
        SceneManager.LoadScene("PlayerVSAI");
    }


    public void PlayerVSPlayer()
    {
        SceneManager.LoadScene("PlayerVSPlayer");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}







    
