using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeniumCoins : CoinsManager
{
    public override int AddCoins(int value)
    {
        return coinsFreenium+= value;
    }

    public override int RemoveCoins(int value)
    {
        return coinsFreenium-= value;
    }

    public override void Start()
    {
        coinsFreenium = PlayerPrefs.GetInt("CoinsFreenium");
    }

    public override void UpdateCoins()
    {
       PlayerPrefs.SetInt("CoinsFreenium", coinsFreenium);
       coinsFreenium = PlayerPrefs.GetInt("CoinsFreenium");
       PlayerPrefs.Save();
       Debug.Log(coinsFreenium);
    }
}
