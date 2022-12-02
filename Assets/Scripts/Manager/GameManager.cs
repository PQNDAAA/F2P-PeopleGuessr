using UnityEngine;
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
            timer.seconds = 20;
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
}
