using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("JSON File")]
    public TextAsset jsonFile;

    [Header("Lists")]
    public PeoplesList peoplelist;

    [Header("UI")]
    public GameObject winUI;
    public GameObject questionsUI;

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

        //Generation
        generateSuspects.Generate();

        //UI
        winUI.SetActive(false);
        questionsUI.SetActive(false);
    }
    void Update()
    {
        if (timer.TimerIsRunning == false && timer.questionsTime == false)
        {
            mydelegate = checkTimer;
            mydelegate.Invoke();
            timer.questionsTime = true;

            
        }
        if (timer.questionsTime == true && !questionsUI.activeSelf)
        {
            timer.questionsTime = false;
            timer.TimerIsRunning = true;
            timer.seconds = 20;
        }
    }

    private void checkTimer()
    {
            questionsUI.SetActive(true);
    }
}
