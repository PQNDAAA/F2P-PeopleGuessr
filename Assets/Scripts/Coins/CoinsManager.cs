using UnityEngine;

public abstract class CoinsManager : MonoBehaviour
{
    public const string CoinsPrenium = "CoinsPrenium";
    public const string CoinsFreenium = "CoinsFreenium";

    public int coinsPrenium = 0;
    public int coinsFreenium = 0;
    abstract public void Start();
    abstract public void UpdateCoins();
    abstract public int AddCoins(int value);
    abstract public int RemoveCoins(int value);
}
