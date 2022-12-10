using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreniumShop : MonoBehaviour
{
    public enum numberOfCoins { _100 = 100, _200 = 200, _300 = 300, _400 = 400, 
        _500 = 500, _600 = 600, _700 = 700, _800 = 800, _900 = 900, _1000= 1000,_2400 = 2400,
    _4875 = 4875,_6200 = 6200, _8250 = 8250,_11000 = 11000}
    public numberOfCoins coinsPrice;

    public Text numberOfCoinsText;

    public CoinsManager coinsManager;


    private void Start()
    {
        int value = (int)coinsPrice;
        numberOfCoinsText.text = value.ToString() + " COINS";

        coinsManager = GetComponent<CoinsManager>();    
    }

    public void BuyPreniumCoins()
    {
        coinsManager.AddCoins((int)coinsPrice);
        coinsManager.UpdateCoins();
    }

}
