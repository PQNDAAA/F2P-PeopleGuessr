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
    public QuestionsList qL;
    public GenerateSuspects gs;
    public PeoplesList peopleslist;

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

    public void MessageAnswer(string yesString, string NoString)
    {
        foreach (QuestionsStructure questionsList in qL.questionsList)//QUESTIONS
        {
            if (questionsList.index == indexQ)
            {
                foreach (var suspectc in gs.suspectCharacteristics)//Suspect Chracteristics
                {
                    if (suspectc.Key == questionsList.answer.ToString())
                    {
                        if (suspectc.Value == "False")
                        {
                            answer.text = NoString;
                        }
                        else if (suspectc.Value == "True")
                        {
                            answer.text = yesString;
                        }
                        else if (questionsList.color.ToString() != "Nothing")
                        {
                            if (suspectc.Value != questionsList.color.ToString())
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
