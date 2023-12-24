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
    [SerializeField] GameObject UýMenu;
    bool Menu_Closed = true;
    public int Score;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) & Menu_Closed)
        {
            Menu_Closed = false;
            UýMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public static bool isHaveKey = false;
    
    public void DeathPlayer()
    {
        player.Death();
    }

    public void endGame()
    {
        //soundManager.CloseMusic();
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
    public void CloseMenu()
    {
        Menu_Closed = true;
        UýMenu.SetActive(false);
        Time.timeScale = 1f;
    }



}

