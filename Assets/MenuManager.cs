using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject options;
    [SerializeField] GameObject menuButtons;

    public void OpenOptions()
    {
        menuButtons.SetActive(false);
        options.SetActive(true);
    }

    public void CloseOptions()
    {
        options.SetActive(false);
        menuButtons.SetActive(true);
    }
}
