using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.UI;

public class PreniumText : MonoBehaviour
{
    Text text;
    public UtilitiesMainMenu utils;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = utils.bank.coinsPrenium.ToString();
    }
}
