using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] GameObject U�Death;
    [SerializeField] TMP_Text Scoretext;
    public int Score;
     

    public static bool isHaveKey = false;
    
    public void DeathPlayer()
    {
        player.Death();
    }

    public void endGame()
    {
        U�Death.SetActive(true);
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

