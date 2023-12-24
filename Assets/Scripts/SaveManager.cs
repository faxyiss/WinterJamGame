using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    [SerializeField] Toggle togle1;
    [SerializeField] Toggle togle2;
    public int MusicOn = 1;
    private int effectOn = 1;
       
    void Update()
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
    public void Save()
    {
        PlayerPrefs.SetInt("Music", MusicOn);
        PlayerPrefs.SetInt("effect", effectOn);
    }
    
}
