using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public const string Coins = "Coins";

    public int coins = 0;
    void Start()
    {
        //PlayerPrefs.SetInt(Coins, coins);
        coins = PlayerPrefs.GetInt("Coins");
    }

    public void UpdateCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
        coins = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.Save();
        Debug.Log(coins);
    }
    public int AddCoins(int value)
    {
        return coins += value;
    }
    public int RemoveCoins(int value)
    {
        return coins -= value;
    }
}
