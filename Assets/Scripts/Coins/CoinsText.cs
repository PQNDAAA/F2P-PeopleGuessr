using UnityEngine;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour
{
    Text text;

    public UtilitiesMainMenu utils;
    void Start()
    {
        text = GetComponent<Text>();
        
    }

    void Update()
    {
        text.text = utils.CoinsManager.coins.ToString();
    }
}
