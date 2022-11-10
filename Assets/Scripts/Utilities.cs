using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utilities : MonoBehaviour
{
    public Text peopleRandomTxt;
    public GameObject GameUI;
    public GameObject WinUI;

    public void RandomPeople()
    {
        CreatePeoplesList random = PeoplesList.peoplelist[UnityEngine.Random.Range(0, PeoplesList.peoplelist.Count)];
        Debug.Log(random.Name);
        peopleRandomTxt.text = random.Name;

    }

    public void checkSearchField(InputField search, Text answerslist)
    {
        if(search != null)
        {
            foreach(CreatePeoplesList people in PeoplesList.peoplelist)
            {
                if(people.Name == search.text)
                {
                    answerslist.text += people.Name + " " + people.Job + " " + people.Size + " " + people.Age + "\n";
                }
                
                if(search.text == peopleRandomTxt.text)
                {
                    GameUI.gameObject.SetActive(false);
                    WinUI.gameObject.SetActive(true);
                }
          
            }
        }
        
        search.text = "";
    }

    public void BackToMainMenu()
    {
        Application.LoadLevel("MAINMENU");
    }
    


}
