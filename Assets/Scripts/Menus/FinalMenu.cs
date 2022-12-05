using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FinalMenu : MonoBehaviour
{
    [Header("InputField")]
    public InputField field;

    [Header("GameObject")]
    public GenerateSuspects gs;
    public GameObject go;

    [Header("Text")]
    public Text answer;
    public Text popupCoins;

    public bool state = false;

    public void ActionConfirm()
    {
        checkAnswer();

        field.interactable = false;

        StartCoroutine(PanelCountdown());
    }

    public IEnumerator PanelCountdown()
    {
        yield return new WaitForSeconds(4);

        Application.LoadLevel("MAINMENU");
    }

    public void checkAnswer()
    {
        foreach(var nameSuspect in gs.trueSuspectNameIndex)
        {
            if(field.text == nameSuspect.Value)
            {
                answer.text = "Congratulations!!";
                state = true;
            } 
            else
            {
                answer.text = "You're wrong, it was " + nameSuspect.Value;
                state = false;
            }
        }
    }
}
