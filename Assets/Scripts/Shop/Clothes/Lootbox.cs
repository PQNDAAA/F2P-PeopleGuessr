using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootbox : ClothesShop
{
    //Function to purchase clothes and check if the player can buy it 
    public override void PurchaseClothes()
    {
        if (userProfile.coinsPrenium >= price)
        {
            coinsManager.RemoveCoins(price);
            coinsManager.UpdateCoins();
            purchaseButton.gameObject.SetActive(false);
        }
    }
    public override void Start()
    {
        coinsManager = GetComponent<CoinsManager>();
    }
    public override void HidePanel()
    {
        purchasePanel.SetActive(false);
    }

    public override void ShowPanel()
    {
        purchasePanel.SetActive(true);
        ShowPrice();
    }

    public override void ShowPrice()
    {
        priceTxt.text = price.ToString();
    }
}
