using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outfit : ClothesShop
{
    public override void PurchaseClothes()
    {
        coinsManager.RemoveCoins(price);
        coinsManager.UpdateCoins();
        purchaseButton.gameObject.SetActive(false);
    }
    public override void HidePanel()
    {
        panel.SetActive(false);
    }

    public override void ShowPanel()
    {
        panel.SetActive(true);
        ShowPrice();
    }

    public override void ShowPrice()
    {
        priceTxt.text = price.ToString();
    }

    public override void Start()
    {
        coinsManager = GetComponent<CoinsManager>();
    }
}
