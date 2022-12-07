using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class UserProfile : MonoBehaviour
{
/*    public const string CoinsPrenium = "CoinsPrenium";
    public const string CoinsFreenium = "CoinsFreenium";*/

    public int coinsPrenium = 0;
    public int coinsFreenium = 0;

    void Start()
    {
        coinsFreenium = PlayerPrefs.GetInt("CoinsFreenium");
        coinsPrenium = PlayerPrefs.GetInt("CoinsPrenium");
    }
}
