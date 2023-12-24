using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject options;
    [SerializeField] GameObject Buttons;
    public void OpenOptions()
    {
        Buttons.SetActive(false);
        options.SetActive(true);
    }
    public void CloseOptions()
    {       
        options.SetActive(false);
        Buttons.SetActive(true);        
    }
}
