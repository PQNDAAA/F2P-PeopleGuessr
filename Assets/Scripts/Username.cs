using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Username : MonoBehaviour
{
    public UserProfile profile;
    public InputField usernameField;
    public GameObject usernamePanel;
    public Text usernameText;
    void Start()
    {
        profile = GetComponent<UserProfile>();
/*
        PlayerPrefs.SetInt("HasPlayed", 0);
        PlayerPrefs.SetString("Username", null);*/

        profile.hasPlayed = PlayerPrefs.GetInt("HasPlayed");
        profile.username = PlayerPrefs.GetString("Username");

        usernameText.text = profile.username;

        CheckUsername();
    }

    public void ConfirmUsername()
    {
        profile.username = usernameField.text;
        usernameText.text = profile.username;

        profile.UpdateUsername();
        profile.UpdateHasPlayed();

        profile.coinsFreenium += 100;
        PlayerPrefs.SetInt("CoinsFreenium", profile.coinsFreenium);
        profile.coinsFreenium = PlayerPrefs.GetInt("CoinsFreenium");
        PlayerPrefs.Save();

        usernamePanel.SetActive(false);  
    }

    public void CheckUsername()
    {
        if (profile.hasPlayed == 0)
        {
            usernamePanel.SetActive(true);
        }
        else
        {
            profile.UpdateHasPlayed();
        }
    }
    
}
