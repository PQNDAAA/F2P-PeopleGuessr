using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsMenu : MonoBehaviour
{
    [Header("CheckBox")]
    public Toggle yesBox;
    public Toggle noBox;

    [Header("Text")]
    public Text questions;

    [Header("GameObject")]
    public GameObject go;
    public QuestionsList qL;
    public GenerateSuspects gs;
    public PeoplesList peopleslist;

    int indexQ;
    
    void Update()
    {
        if (go.activeSelf)
        {
            noBox.interactable = true;
            yesBox.interactable = true;
        }
    }

    public void ActionConfirm()
    {
        checkAnswer();

        noBox.interactable = false;
        yesBox.interactable = false;

        go.SetActive(false);
    }

    public void YesIsOn()
    {
        if (yesBox.isOn)
        {
            noBox.isOn=false;
        }
    }
    public void NoIsOn()
    {
        if (noBox.isOn)
        {
            yesBox.isOn = false;
        }
    }
    public int RandomQuestion()
    {
        System.Random random = new System.Random();
        int index = random.Next(qL.questionsList.questions.Count);

        foreach (QuestionsStructure questionsList in qL.questionsList)
        {
            if(questionsList.index == index)
            {
                questions.text = questionsList.question.ToString();
                Debug.Log(questionsList.question);
            } 
        }
        return indexQ+= index;
    }

    public void checkAnswer()
    {

        if (yesBox.isOn)
        {
            yesBox.isOn = false;

            foreach (QuestionsStructure questionsList in qL.questionsList)
            {
                if (questionsList.index == indexQ)
                {
                    Debug.Log(questionsList.question);
                }
            }
        }
        if (noBox.isOn)
        {
            noBox.isOn = false;

            foreach (QuestionsStructure questionsList in qL.questionsList)
            {
                if (questionsList.index == indexQ)
                {
                    foreach(MainStructure people in peopleslist.peoplel.ToList())
                    {
                        foreach(var s in gs.truesuspect)
                        {
                            if(people.Name == s.Value)
                            {
                               
                            }
                        }
                    }
                    Debug.Log(questionsList.answer);
                }
            }
        }
    }
}
