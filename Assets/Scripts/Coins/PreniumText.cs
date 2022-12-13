using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.UI;

public class PreniumText : MonoBehaviour
{
    //Define the prenium text with the target currency
    Text text;
    public UserProfile userProfile;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = userProfile.coinsPrenium.ToString();
    }
}
