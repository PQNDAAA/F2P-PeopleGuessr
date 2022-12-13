using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Username : MonoBehaviour
{
    //I declare the different variables to enter the username 
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

        //I recover variable in the PlayerPrefs to compare in CheckUsername
        profile.hasPlayed = PlayerPrefs.GetInt("HasPlayed");

        //I get this variable to define it in the profile text 
        profile.username = PlayerPrefs.GetString("Username");
        usernameText.text = profile.username;

        CheckUsername();
    }

    public void ConfirmUsername()
    {
        //I define various texts
        profile.username = usernameField.text;
        usernameText.text = profile.username;

        //Update
        profile.UpdateUsername();
        profile.UpdateHasPlayed();

        //Add and Update
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
