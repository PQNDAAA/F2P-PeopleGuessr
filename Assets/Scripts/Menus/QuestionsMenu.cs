using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsMenu : MonoBehaviour
{
    [Header("CheckBox")]
    public Toggle yesBox;
    public Toggle noBox;

    public GameObject go;

    public void ActionConfirm()
    {
        if (yesBox.isOn)
        {
            yesBox.isOn = false;
        }
        if (noBox.isOn)
        {
            noBox.isOn = false;
        }

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
}
