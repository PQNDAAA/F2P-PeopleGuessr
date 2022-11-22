using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public GenerateSuspects generateSuspects;
    public GameObject WinUI;
    public GameObject GameUI;
    public PeoplesList peoplelist;
    public TextAsset JSONFile;

    void Start()
    {
        peoplelist.peoplel = JsonUtility.FromJson <PeoplesList.CreatePeopleList>(JSONFile.text);

        generateSuspects.Generate();

        WinUI.SetActive(false);
        GameUI.SetActive(false);


        //var outputString = JsonUtility.ToJson(peoplelist.peoplel);
        //File.WriteAllText("C:\\Program Files\\Peopleslist.json", outputString);

    }
}
