using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ClothesShop : MonoBehaviour
{
    public int price = 0;
    public Text priceTxt;
    public UserProfile userProfile;
    public GameObject panel;
    abstract public void BuyClothesByPreniumCoins();
    abstract public void ShowPanel();
    abstract public void HidePanel();
    abstract public void ShowPrice();
}
