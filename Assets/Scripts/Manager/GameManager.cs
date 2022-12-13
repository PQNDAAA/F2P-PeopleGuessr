using UnityEngine;
using UnityEngine.Diagnostics;

public class GameManager : MonoBehaviour
{
    [Header("JSON File")]
    public TextAsset jsonFile;
    public TextAsset questionsFile;

    [Header("UI")]
    public GameObject questionsUI;
    public GameObject finalUI;

    public Utilities utils;

    delegate void actiondelegate();
    actiondelegate gameStatusDelegate;

    void Start()
    {
        //JSON File
        utils.referencePeopleList.globalPeoplesList = JsonUtility.FromJson<PeoplesList.CreatePeopleList>(jsonFile.text);
        utils.referenceQuestionslist.globalQuestionsList = JsonUtility.FromJson<QuestionsList.IQuestionsList>(questionsFile.text);

        //Declare my delegate 
        gameStatusDelegate = PlayTime;
        gameStatusDelegate.Invoke();

        //UI
        finalUI.SetActive(false);
        questionsUI.SetActive(false);

        utils.popupCoinsText.gameObject.SetActive(false);
    }
    void Update()
    {
        //Check the time to show the questions panel
        if (utils.timer.TimerIsRunning == false && utils.timer.questionsTime == false)
        {
            if(utils.qm.nbExecutionsPanel != utils.qm.maxExecutionsPanel)
            {
                gameStatusDelegate = QuestionsTime;
                gameStatusDelegate.Invoke();
            } 
            else
            {
                gameStatusDelegate = FinalTime;
                gameStatusDelegate.Invoke();
            }
        }

        if (utils.timer.questionsTime && !questionsUI.activeSelf)
        {
            utils.timer.questionsTime = false;
            utils.timer.TimerIsRunning = true;
            utils.timer.seconds = 10;
        }

        //Check if the player won or not 
        if (utils.finalmenu.isWin)
        {
            //This function in Utilities is with Add & Update of CoinsManager to simplify the class GameManager 
            utils.AddCoins(100,1f);

            utils.PopupCoins(100,3); 
            utils.finalmenu.isWin = false; //Do once
        }
    }
    //The game has different time like on the bottom (Question,Final...)
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
        utils.generateSuspects.Generate();
        utils.generateSuspects.TrueSuspect();
    }
}
