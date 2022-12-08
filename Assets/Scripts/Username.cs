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
