using UnityEngine;

public abstract class CoinsManager : MonoBehaviour
{
    public UtilitiesMainMenu utils;
    abstract public void Start();
    abstract public void UpdateCoins();
    abstract public int AddCoins(int value);
    abstract public int RemoveCoins(int value);
    abstract public string DisplayCoins();

}
