using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Method to wait 3 seconds to load Main Menu scene
        Invoke("LoadMainMenu", 3);
    }

    //Method to load Main Menu scene
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
