using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class UtilitiesMainMenu : MonoBehaviour
{
    public GameObject shopCoinsPanel;
    public GameObject clothesShop;
    public GameObject loginPanel;

    public void AccessToPreniumShop()
    {
        shopCoinsPanel.SetActive(true);
    }
    public void AccessToShop()
    {
        clothesShop.SetActive(true);
    }
}
