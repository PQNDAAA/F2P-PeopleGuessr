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
    public GameObject questionsUI;
    public GameObject finalUI;
    public Utilities utils;

    [Header("Generation")]
    public GenerateSuspects generateSuspects;

    delegate void actiondelegate();
    actiondelegate mydelegate;

    void Start()
    {
        //JSON File
        peoplelist.peoplel = JsonUtility.FromJson<PeoplesList.CreatePeopleList>(jsonFile.text);
        questionslist.questionsList = JsonUtility.FromJson<QuestionsList.IQuestionsList>(questionsFile.text); 

        mydelegate = PlayTime;
        mydelegate.Invoke();

        //UI
        finalUI.SetActive(false);
        questionsUI.SetActive(false);

        utils.popupCoinsText.gameObject.SetActive(false);
    }
    void Update()
    {
        if (utils.timer.TimerIsRunning == false && utils.timer.questionsTime == false)
        {
            if(utils.qm.nbExecutionsPanel != utils.qm.maxExecutionsPanel)
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

        if (utils.timer.questionsTime && !questionsUI.activeSelf)
        {
            utils.timer.questionsTime = false;
            utils.timer.TimerIsRunning = true;
            utils.timer.seconds = 10;
        }

        if (utils.finalmenu.isWin)
        {
            utils.AddCoins(100,1f);
            utils.PopupCoins(100,3); 
            utils.finalmenu.isWin = false;
        }
    }
    private void QuestionsTime()
    {
        questionsUI.SetActive(true);
        utils.timer.questionsTime = true;
        utils.qm.RandomQuestion();
        utils.AddExecutions(1);
    }
    private void FinalTime()
    {
        finalUI.SetActive(true);
    }
    private void PlayTime()
    {
        generateSuspects.Generate();
        generateSuspects.TrueSuspect();
    }
}
