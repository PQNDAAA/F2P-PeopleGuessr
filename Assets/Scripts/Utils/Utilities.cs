using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Utilities : MonoBehaviour
{
    public GameManager gameManager;
    public CoinsManager coinsManager;
    public FinalMenu finalmenu;
    public QuestionsMenu qm;
    public Timer timer;

    public Text popupCoinsText;
    public int numberAddCoins = 100;

    void Start()
    {
        coinsManager = GetComponent<CoinsManager>();
    }
    public IEnumerator CountdownPopupCoins (int value)
    {
        yield return new WaitForSeconds(value);

        popupCoinsText.gameObject.SetActive(false);
    }
    public int AddExecutions()
    {
        return qm.nbExecutionsPanel += 1;
    }
    public void PopupCoins(int value,int time)
    {
        popupCoinsText.gameObject.SetActive(true);
        popupCoinsText.text = "+"+ value +" Coins";
        StartCoroutine(CountdownPopupCoins(time));
    }
    public void AddCoins(int value)
    {
        coinsManager.AddCoins(value);
        coinsManager.UpdateCoins();
    }

}
