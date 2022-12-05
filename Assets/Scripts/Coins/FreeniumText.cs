using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeniumText : MonoBehaviour
{
   Text text;
    public CoinsManager coinsManager;
    void Start()
    {
        text = GetComponent<Text>();
        coinsManager = GetComponent<CoinsManager>();
    }
    void Update()
    {
        text.text = coinsManager.coinsFreenium.ToString();
    }
}
