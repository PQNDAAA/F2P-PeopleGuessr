using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootbox : ClothesShop
{
    public override void BuyClothesByPreniumCoins()
    {
        throw new System.NotImplementedException();
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
}
