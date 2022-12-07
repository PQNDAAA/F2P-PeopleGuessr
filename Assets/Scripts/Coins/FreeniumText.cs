using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeniumText : MonoBehaviour
{
   Text text;
    public UserProfile userProfile;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = userProfile.coinsFreenium.ToString();
    }
}
