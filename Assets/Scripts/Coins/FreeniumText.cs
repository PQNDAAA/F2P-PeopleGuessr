using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class FreeniumText : MonoBehaviour
{
   //Define the freenium text with the target currency
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
