using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MainGame : MonoBehaviour
{
    public Utilities utils;
    public GameObject WinUI;
    public PeoplesList peoplelist;

    void Start()
    {
        utils.RandomPeople();
        WinUI.SetActive(false);

        var outputString = JsonUtility.ToJson(peoplelist.peoplel);
        File.WriteAllText("C:\\Program Files\\Peopleslist.json", outputString);

    }
}
