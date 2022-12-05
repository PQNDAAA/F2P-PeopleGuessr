using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreniumText : MonoBehaviour
{
    Text text;
    public CoinsManager coinsManager;
    void Start()
    {
        text = GetComponent<Text>();
        coinsManager = GetComponent<CoinsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinsManager.coinsPrenium.ToString();
    }
}
