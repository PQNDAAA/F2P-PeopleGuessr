using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class UserProfile : MonoBehaviour
{
/*    public const string CoinsPrenium = "CoinsPrenium";
    public const string CoinsFreenium = "CoinsFreenium";*/

    public string username;
    public int hasPlayed = 0;

    public int coinsPrenium = 0;
    public int coinsFreenium = 0;

    void Start()
    {
        coinsFreenium = PlayerPrefs.GetInt("CoinsFreenium");
        coinsPrenium = PlayerPrefs.GetInt("CoinsPrenium"); 
    }

    public void UpdateHasPlayed()
    {
        hasPlayed += 1;
        PlayerPrefs.SetInt("HasPlayed", hasPlayed);
        hasPlayed = PlayerPrefs.GetInt("HasPlayed");
        PlayerPrefs.Save();
        Debug.Log("The player launched the game " + hasPlayed + " times");
    }
    public void UpdateUsername()
    {
        PlayerPrefs.SetString("Username", username);
        username = PlayerPrefs.GetString("Username");
        PlayerPrefs.Save();
    }
}
