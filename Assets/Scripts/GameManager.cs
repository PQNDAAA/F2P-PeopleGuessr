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

    [Header("Executions Number")]
    public int nbExecutions;

    void Start()
    {
        //JSON File
        peoplelist.peoplel = JsonUtility.FromJson<PeoplesList.CreatePeopleList>(jsonFile.text);

        //Generation
        generateSuspects.Generate();
        generateSuspects.TrueSuspect();

        //UI
        winUI.SetActive(false);
        questionsUI.SetActive(false);
    }
    void Update()
    {
        if (timer.TimerIsRunning == false && timer.questionsTime == false)
        {
            if(nbExecutions != 3)
            {
                mydelegate = questionsTime;
                mydelegate.Invoke();
            } 
            else
            {
                Debug.Log("The game is finished");
            }
        }
        if (timer.questionsTime == true && !questionsUI.activeSelf)
        {
            timer.questionsTime = false;
            timer.TimerIsRunning = true;
            timer.seconds = 20;
        }
    }

    private void questionsTime()
    {
            questionsUI.SetActive(true);
            timer.questionsTime = true;
            addExecutions();
    }

    private int addExecutions()
    {
        return nbExecutions += 1;
    }
}