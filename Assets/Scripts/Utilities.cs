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
    Dictionary<string, object> peopleRandomInfo = new Dictionary<string, object>();

    public void RandomPeople()
    {
        CreatePeoplesList random = PeoplesList.peoplelist[UnityEngine.Random.Range(0, PeoplesList.peoplelist.Count)];
        Debug.Log(random.Name);
        peopleRandomTxt.text = random.Name;

        foreach (CreatePeoplesList people in PeoplesList.peoplelist)
        {
            if (people.Name == peopleRandomTxt.text)
            {
                peopleRandomInfo.Add("Name", people.Name);
                peopleRandomInfo.Add("Job", people.Job);
                peopleRandomInfo.Add("Age", people.Age);

            }
        }
     }

    public void checkSearchField(InputField search, Text answerslist)
    {
        if(search.text != null && !answerslist.text.Contains(search.text))
        {
            foreach(CreatePeoplesList people in PeoplesList.peoplelist)
            {
                if(people.Name == search.text)
                {
                    answerslist.text += people.Name + " " + people.Job + " " + people.Size + " " + people.Age + "\n";
                    compareCorrectPerson(search);
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

    public void compareCorrectPerson(InputField search)
    {
        var age = peopleRandomInfo["Age"];

        foreach (CreatePeoplesList people in PeoplesList.peoplelist)
        {
            if (people.Name.Contains(search.text)) 
            {
                if (peopleRandomInfo.ContainsValue(people.Name))
                {
                    Debug.Log("The name " + search.text + " is correct");
                }
                else
                {
                    Debug.Log("The name " + search.text + " isn't correct");
                }
                if(peopleRandomInfo.ContainsValue(people.Age))
                {
                    Debug.Log(people.Age + " == " + age);
                } else
                {
                    Debug.Log(people.Age + " != " + age);
                }
                if (peopleRandomInfo.ContainsValue(people.Job))
                {
                    Debug.Log("It's the correct job.");
                }
                else
                {
                    Debug.Log("It's not the correct job.");
                }
            }
         

        }
    }

    public void BackToMainMenu()
    {
        Application.LoadLevel("MAINMENU");
    }
    


}
