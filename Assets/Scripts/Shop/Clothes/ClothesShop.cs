using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ClothesShop : MonoBehaviour
{
    public int price = 0;
    public Text priceTxt;
    public GameObject panel;
    public CoinsManager coinsManager;
    public Button purchaseButton;
    public UserProfile userProfile;

    abstract public void Start();

    abstract public void PurchaseClothes();
    abstract public void ShowPanel();
    abstract public void HidePanel();
    abstract public void ShowPrice();
}
