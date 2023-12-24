using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers: MonoBehaviour
{
    [SerializeField] public string nextSceneName;
    
    
    public void LoadNextSceen()
    {

        SceneManager.LoadScene(nextSceneName);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

}
