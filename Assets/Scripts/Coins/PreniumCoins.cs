using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreniumCoins : CoinsManager
{
    public override int AddCoins(int value)
    {
        return utils.bank.coinsPrenium += value;
    }

    public override string DisplayCoins()
    {
        return utils.bank.coinsPrenium.ToString();
    }

    public override int RemoveCoins(int value)
    {
        return utils.bank.coinsPrenium -= value;
    }

    public override void Start()
    {
        utils.bank.coinsPrenium = PlayerPrefs.GetInt("CoinsPrenium");
    }

    public override void UpdateCoins()
    {
        PlayerPrefs.SetInt("CoinsPrenium", utils.bank.coinsPrenium);
        utils.bank.coinsPrenium = PlayerPrefs.GetInt("CoinsPrenium");
        PlayerPrefs.Save();
        Debug.Log(utils.bank.coinsPrenium);
    }
}
