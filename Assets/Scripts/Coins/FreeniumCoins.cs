using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeniumCoins : CoinsManager
{
    //Define the freenium coins 
    public override int AddCoins(int value)
    {
        return userProfile.coinsFreenium += value;
    }

    public override string DisplayCoins()
    {
        return userProfile.coinsFreenium.ToString();
    }

    public override int RemoveCoins(int value)
    {
        return userProfile.coinsFreenium -= value;
    }

    public override void UpdateCoins()
    {
       PlayerPrefs.SetInt("CoinsFreenium", userProfile.coinsFreenium);
        userProfile.coinsFreenium = PlayerPrefs.GetInt("CoinsFreenium");
       PlayerPrefs.Save();
       Debug.Log(userProfile.coinsFreenium);
    }
}
