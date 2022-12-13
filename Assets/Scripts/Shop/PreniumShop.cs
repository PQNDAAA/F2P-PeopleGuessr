using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreniumShop : MonoBehaviour
{
    //I created a lot of prices to be modular in the system

    //You create the GameObject where you will drop a script "Prenium Shop" & the currency that you want "Prenium or Freenium"
    //You must define various parameters like coins price, number of coins....
    //At the beginning, the game detect automatically the currency you selected 
    public enum numberOfCoins { _100 = 100, _200 = 200, _300 = 300, _400 = 400, 
        _500 = 500, _600 = 600, _700 = 700, _800 = 800, _900 = 900, _1000= 1000,_2400 = 2400,
    _4875 = 4875,_6200 = 6200, _8250 = 8250,_11000 = 11000}

    public numberOfCoins coinsPrice;

    public Text numberOfCoinsText;
    public CoinsManager coinsManager;


    private void Start()
    {
        //I set the number of coins in this text.
        int value = (int)coinsPrice;
        numberOfCoinsText.text = value.ToString() + " COINS";

        coinsManager = GetComponent<CoinsManager>();    
    }

    public void BuyPreniumCoins()
    {
        //Add and Update the database and text
        coinsManager.AddCoins((int)coinsPrice);
        coinsManager.UpdateCoins();
    }

}
