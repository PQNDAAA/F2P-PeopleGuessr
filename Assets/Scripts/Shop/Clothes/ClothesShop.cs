using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClothesShop : MonoBehaviour
{
    public UserProfile userProfile;
    public GameObject panel;
    abstract public void BuyClothesByPreniumCoins();
    abstract public void ShowPanel();
    abstract public void HidePanel();

}
