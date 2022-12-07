using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreniumShop : MonoBehaviour
{
    public enum numberOfCoins { price1 = 100, price2 = 200, price3 = 300, price4 = 400, 
        price5 = 500, price6 = 600, price7 = 700 }
    public numberOfCoins nb;

    public Text priceText;

    public CoinsManager coinsManager;


    private void Start()
    {
        int value = (int)nb;
        priceText.text = value.ToString();

        coinsManager = GetComponent<CoinsManager>();    
    }

    public void BuyPreniumCoins()
    {
        coinsManager.AddCoins((int)nb);
        coinsManager.UpdateCoins();
    }

}
