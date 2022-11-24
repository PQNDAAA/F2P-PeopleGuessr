using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static MainStructure;

public class Utilities : MonoBehaviour
{
    public Text peopleRandomTxt;
    public GameObject GameUI;
    public GameObject WinUI;
    public PeoplesList peopleslist; 

    Dictionary<string, object> peopleRandomInfo = new Dictionary<string, object>();

    public void BackToMainMenu()
    {
        Application.LoadLevel("MAINMENU");
    }
    


}
