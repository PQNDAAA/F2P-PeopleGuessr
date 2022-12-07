using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreniumCoins : CoinsManager
{
    public override int AddCoins(int value)
    {
        return userProfile.coinsPrenium += value;
    }

    public override string DisplayCoins()
    {
        return userProfile.coinsPrenium.ToString();
    }

    public override int RemoveCoins(int value)
    {
        return userProfile.coinsPrenium -= value;
    }
    public override void UpdateCoins()
    {
        PlayerPrefs.SetInt("CoinsPrenium", userProfile.coinsPrenium);
        userProfile.coinsPrenium = PlayerPrefs.GetInt("CoinsPrenium");
        PlayerPrefs.Save();
        Debug.Log(userProfile.coinsPrenium);
    }
}
