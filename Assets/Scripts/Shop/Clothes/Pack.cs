using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pack : ClothesShop
{
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

    public override void PurchaseClothes()
    {
        if (userProfile.coinsPrenium >= price)
        {
            coinsManager.RemoveCoins(price);
            coinsManager.UpdateCoins();
            purchaseButton.gameObject.SetActive(false);
        }
    }
}
