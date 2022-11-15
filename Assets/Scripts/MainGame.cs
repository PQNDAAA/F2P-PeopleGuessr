using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using static MainStructure;
using static PeoplesList;

public class MainGame : MonoBehaviour
{
    public Utilities utils;
    public GameObject WinUI;
    public PeoplesList peoplelist;
    public TextAsset JSONFile;

    void Start()
    {
        peoplelist.peoplel = JsonUtility.FromJson<CreatePeopleList>(JSONFile.text);

        utils.RandomPeople();
        WinUI.SetActive(false);

        //var outputString = JsonUtility.ToJson(peoplelist.peoplel);
        //File.WriteAllText("C:\\Program Files\\Peopleslist.json", outputString);

    }
}
