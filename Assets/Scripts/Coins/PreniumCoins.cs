using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreniumCoins : CoinsManager
{
    public override int AddCoins(int value)
    {
        return coinsPrenium += value;
    }

    public override string DisplayCoins()
    {
        return coinsPrenium.ToString();
    }

    public override int RemoveCoins(int value)
    {
        return coinsPrenium -= value;
    }

    public override void Start()
    {
        coinsPrenium = PlayerPrefs.GetInt("CoinsPrenium");
    }

    public override void UpdateCoins()
    {
        PlayerPrefs.SetInt("CoinsPrenium", coinsPrenium);
        coinsPrenium = PlayerPrefs.GetInt("CoinsPrenium");
        PlayerPrefs.Save();
        Debug.Log(coinsPrenium);
    }
}
