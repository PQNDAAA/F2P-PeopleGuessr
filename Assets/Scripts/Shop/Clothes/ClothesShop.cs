using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ClothesShop : MonoBehaviour
{
    //Define characteristics to create objects in the clothes store

    //You create the GameObject where you will drop a script like "Outfit, Pack..." 
    //This GameObject will show the content of "pack, outfit...." so like a lootbox image  
    //These references are the panel to buy the content of the previous GameObject

    //You must define various parameters like price, purchasePanel....
    public int price = 0;
    public Text priceTxt;
    public GameObject purchasePanel;
    public CoinsManager coinsManager;
    public Button purchaseButton;
    public UserProfile userProfile;

    abstract public void Start();
    abstract public void PurchaseClothes();
    abstract public void ShowPanel();
    abstract public void HidePanel();
    abstract public void ShowPrice();
}
