using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] GameObject UýDeath;
    [SerializeField] TMP_Text Scoretext;
    [SerializeField] SoundManager soundManager;
    public int Score;
     

    public static bool isHaveKey = false;
    
    public void DeathPlayer()
    {
        player.Death();
    }

    public void endGame()
    {
        soundManager.CloseMusic();
        UýDeath.SetActive(true);
    }
    public void winGame()
    {

    }
    public void AddScore()
    {
        
        Score++;
        Scoretext.text = $"Score : {Score}";
    }



}

