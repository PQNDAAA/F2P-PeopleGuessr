using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsMenu : MonoBehaviour
{
    [Header("CheckBox")]
    public Toggle yesBox;
    public Toggle noBox;

    [Header("Text")]
    public Text questions;
    public Text answer;

    [Header("GameObject")]
    public GameObject go;
    public Utilities utils;

    [Header("Executions Number")]
    public int nbExecutionsPanel;
    public int maxExecutionsPanel = 3;

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

        StartCoroutine(PanelCountdown());
    }
    public IEnumerator PanelCountdown()
    {
        yield return new WaitForSeconds(4);

        go.SetActive(false);
        answer.text = "";
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

    //This function generates a random question from the json file 
    public int RandomQuestion()
    {
        System.Random random = new System.Random();
        int index = random.Next(utils.referenceQuestionslist.globalQuestionsList.questionsList.Count);

        foreach (QuestionsStructure questionsList in utils.referenceQuestionslist.globalQuestionsList)
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
                                        if (noBox.isOn)
                                        {
                                            noBox.isOn = false;

            MessageAnswer("No you're wrong", "Your answer is OK");

                                        } else if (yesBox.isOn)
                                        {
                                            yesBox.isOn = false;

            MessageAnswer("Your answer is OK", "No you're wrong");
        }
                                    }

    //This function makes Messages and Check the answer with suspect characteristics 
    public void MessageAnswer(string yesString, string NoString)
    {
        foreach (QuestionsStructure questionsList in utils.referenceQuestionslist.globalQuestionsList)//QUESTIONS
        {
            if (questionsList.index == indexQ)
            {
                foreach (var suspectParameters in utils.generateSuspects.suspectCharacteristics)//Suspect Chracteristics
                {
                    if (suspectParameters.Key == questionsList.answer.ToString())
                    {
                        if (suspectParameters.Value == "False")
                        {
                            answer.text = NoString;
                        }
                        else if (suspectParameters.Value == "True")
                        {
                            answer.text = yesString;
                        }
                        else if (questionsList.color.ToString() != "Nothing")
                        {
                            if (suspectParameters.Value != questionsList.color.ToString())
                            {
                                answer.text = NoString;
                            }
                            else
                            {
                                answer.text = yesString;
                            }
                        }
                    }
                }
            }
        }
    }
}
