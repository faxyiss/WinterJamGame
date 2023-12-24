using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    int onMusic;
    int onEffect;
    void Start()
    {
       onEffect = PlayerPrefs.GetInt("effect");
       onMusic = PlayerPrefs.GetInt("Music");

        if (onMusic == 1)
        {
            GetComponent<AudioSource>().volume = 0.2f;
        }
        else if (onMusic == 0)
        {
            GetComponent<AudioSource>().volume = 0f;
        }

    }
    public void CloseMusic()
    {
        GetComponent<AudioSource>().volume = 0f;
    }
  
    

    
}
