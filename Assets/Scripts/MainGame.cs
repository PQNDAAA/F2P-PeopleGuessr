using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public Utilities utils;
    public GameObject WinUI;
    public PeoplesList peoplelist;
    public TextAsset JSONFile;

    void Start()
    {
        peoplelist.peoplel = JsonUtility.FromJson <PeoplesList.CreatePeopleList>(JSONFile.text);

        utils.RandomPeople();
        WinUI.SetActive(false);

        //var outputString = JsonUtility.ToJson(peoplelist.peoplel);
        //File.WriteAllText("C:\\Program Files\\Peopleslist.json", outputString);

    }
}
