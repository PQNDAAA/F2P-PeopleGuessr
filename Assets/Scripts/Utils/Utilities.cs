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
    public GenerateSuspects generateSuspects;

    public AudioSource audioSourceWin;
    public AudioSource audioSourceLoose;
    public AudioSource audioSourceCoins;

    public PeoplesList referencePeopleList;
    public QuestionsList referenceQuestionslist;

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
    public int AddExecutions(int value)
    {
        return qm.nbExecutionsPanel += value;
    }
    public void PopupCoins(int value,int time)
    {
        popupCoinsText.gameObject.SetActive(true);
        popupCoinsText.text = "+"+ value +" Coins";
        StartCoroutine(CountdownPopupCoins(time));
    }
    public void AddCoins(int value,float audiodelay)
    {
        coinsManager.AddCoins(value);
        coinsManager.UpdateCoins();
        audioSourceCoins.PlayDelayed(audiodelay);  
    }

}
