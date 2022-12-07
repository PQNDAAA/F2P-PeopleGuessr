using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeniumText : MonoBehaviour
{
   Text text;
    public UtilitiesMainMenu utils;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = utils.bank.coinsFreenium.ToString();
    }
}
