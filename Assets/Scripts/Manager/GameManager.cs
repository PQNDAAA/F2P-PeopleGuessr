using UnityEngine;
using UnityEngine.Diagnostics;

public class GameManager : MonoBehaviour
{
    [Header("JSON File")]
    public TextAsset jsonFile;
    public TextAsset questionsFile;

    [Header("Lists")]
    public PeoplesList peoplelist;
    public QuestionsList questionslist;

    [Header("UI")]
    public GameObject winUI;
    public GameObject questionsUI;
    public GameObject finalUI;
    //a refaire
    public QuestionsMenu qm;
    public CoinsManager coinsManager;
    public Utilities utils;

    [Header("Generation")]
    public GenerateSuspects generateSuspects;

    [Header("Timer")]
    public Timer timer;

    delegate void actiondelegate();
    actiondelegate mydelegate;

    void Start()
    {
        //JSON File
        peoplelist.peoplel = JsonUtility.FromJson<PeoplesList.CreatePeopleList>(jsonFile.text);
        questionslist.questionsList = JsonUtility.FromJson<QuestionsList.IQuestionsList>(questionsFile.text);

        coinsManager = GetComponent<CoinsManager>();    

        mydelegate = PlayTime;
        mydelegate.Invoke();

        //UI
        winUI.SetActive(false);
        finalUI.SetActive(false);
        questionsUI.SetActive(false);
    }
    void Update()
    {
        if (timer.TimerIsRunning == false && timer.questionsTime == false)
        {
            if(qm.nbExecutionsPanel != qm.maxExecutionsPanel)
            {
                mydelegate = QuestionsTime;
                mydelegate.Invoke();
            } 
            else
            {
                mydelegate = FinalTime;
                mydelegate.Invoke();
            }
        }
        if (timer.questionsTime == true && !questionsUI.activeSelf)
        {
            timer.questionsTime = false;
            timer.TimerIsRunning = true;
            timer.seconds = 10;
        }
        if(utils.finalmenu.state == true)
        {
            PopupCoins();
            coinsManager.AddCoins(100);
            coinsManager.UpdateCoins();
            utils.finalmenu.state = false;
        }
    }

    private void QuestionsTime()
    {
        questionsUI.SetActive(true);
        timer.questionsTime = true;
        qm.RandomQuestion();
        AddExecutions();
    }
    private void FinalTime()
    {
        utils.finalmenu.popupCoins.gameObject.SetActive(false);
        finalUI.SetActive(true);
    }
    private void PlayTime()
    {
        generateSuspects.Generate();
        generateSuspects.TrueSuspect();
    }
    private int AddExecutions()
    {
        return qm.nbExecutionsPanel += 1;
    }
    public void PopupCoins()
    {
        utils.finalmenu.popupCoins.gameObject.SetActive(true);
        utils.finalmenu.popupCoins.text = "+ " + coinsManager.DisplayCoins() + " Coins";
        StartCoroutine(utils.Countdown(3));
    }
}
