using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class UtilitiesMainMenu : MonoBehaviour
{
    public GameObject shopCoinsPanel;
    public GameObject clothesShop;
    public GameObject settingsPanel;
    public GameObject dressingPanel;

    //Functions to access to various panels 
    public void AccessToPreniumShop()
    {
        shopCoinsPanel.SetActive(true);
    }
    public void AccessToShop()
    {
        clothesShop.SetActive(true);
    }
    public void AccessToSettings()
    {
        settingsPanel.SetActive(true);
    }
    public void AccessToDressing()
    {
        dressingPanel.SetActive(true);
    }
}
