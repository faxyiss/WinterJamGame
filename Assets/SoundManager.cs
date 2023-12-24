using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    int onMusic;
    int onEffect;
    void Start()
    {
       onEffect = PlayerPrefs.GetInt("Music");
       onMusic = PlayerPrefs.GetInt("effect");

        if (onMusic == 1)
        {
            GetComponent<AudioSource>().volume = 0.4f;
        }
        else if (onMusic == 0)
        {
            GetComponent<AudioSource>().volume = 0f;
        }

    }
  
    

    
}
