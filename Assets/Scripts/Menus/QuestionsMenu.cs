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
        return indexQ = index;
    }

    public void checkAnswer()
    {
            foreach (QuestionsStructure questionsList in qL.questionsList)
            {
                if (questionsList.index == indexQ)
                {
                    foreach(var people in peopleslist.peoplel)
                    { 
                        foreach (var s in gs.truesuspect)
                        {
                            if(people.Name == s.Value)
                            {
                                foreach(var suspectc in gs.suspectCharacteristics)
                                {
                                    //Debug.Log(questionsList.answer);
                                    if(suspectc.Key == questionsList.answer.ToString())
                                    {
                                        if (noBox.isOn)
                                        {
                                            noBox.isOn = false;

                                            if (suspectc.Value == "False")
                                            {
                                                Debug.Log("Your answer is OK");
                                            }
                                            else if (suspectc.Value == "True")
                                            {
                                                Debug.Log("No, you're wrong");
                                            } 
                                            else if(questionsList.color.ToString() != "Nothing")
                                            {
                                                if (suspectc.Value != questionsList.color.ToString())
                                                {
                                                Debug.Log("Your answer is OK");
                                            } 
                                                else
                                                {
                                                Debug.Log("No, you're wrong");
                                            }
                                            }

                                        } else if (yesBox.isOn)
                                        {
                                            yesBox.isOn = false;

                                            if (suspectc.Value == "False")
                                            {
                                            Debug.Log("No, you're wrong");
                                        }
                                            else if (suspectc.Value == "True")
                                            {
                                            Debug.Log("Your answer is OK");
                                        }
                                            if (questionsList.color.ToString() != "Nothing")
                                            {
                                                if (suspectc.Value != questionsList.color.ToString())
                                                {
                                                Debug.Log("No, you're wrong");
                                            }
                                                else
                                                {
                                                Debug.Log("Your answer is OK");
                                            }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
    }
}
