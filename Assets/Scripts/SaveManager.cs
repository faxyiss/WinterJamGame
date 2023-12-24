using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    [SerializeField] Toggle togle1;
    [SerializeField] Toggle togle2;
    int MusicOn;
    int effectOn;
    private void Start()
    {
        Debug.Log("Music  :" + PlayerPrefs.GetInt("Music"));
        Debug.Log("effect  :" + PlayerPrefs.GetInt("effect"));

        if (PlayerPrefs.GetInt("Music") == 1)
        {
            togle1.isOn = true;

        }
        else
        {
            togle1.isOn = false;

        }

        if (PlayerPrefs.GetInt("effect") == 1)
        {
            togle2.isOn = true;

        }
        else
        {
            togle2.isOn = false;

        }
        
    }
    

    public void Save()
    {
        PlayerPrefs.SetInt("Music", MusicOn);
        PlayerPrefs.SetInt("effect", effectOn);
    }
    public void changed()
    {
        if (togle1.isOn)
        {
            MusicOn = 1;
        }
        else
        {
            MusicOn = 0;
        }

        if (togle2.isOn)
        {
            effectOn = 1;
        }
        else
        {
            effectOn = 0;
        }
    }

    
    
}
