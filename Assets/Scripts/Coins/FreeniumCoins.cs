using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeniumCoins : CoinsManager
{
    public override int AddCoins(int value)
    {
        return utils.bank.coinsFreenium += value;
    }

    public override string DisplayCoins()
    {
        return utils.bank.coinsFreenium.ToString();
    }

    public override int RemoveCoins(int value)
    {
        return utils.bank.coinsFreenium -= value;
    }

    public override void Start()
    {
        utils.bank.coinsFreenium = PlayerPrefs.GetInt("CoinsFreenium");
    }

    public override void UpdateCoins()
    {
       PlayerPrefs.SetInt("CoinsFreenium", utils.bank.coinsFreenium);
        utils.bank.coinsFreenium = PlayerPrefs.GetInt("CoinsFreenium");
       PlayerPrefs.Save();
       Debug.Log(utils.bank.coinsFreenium);
    }
}
