using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
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
        MainStructure random = PeoplesList.peoplelist[UnityEngine.Random.Range(0, PeoplesList.peoplelist.Count)];
        peopleRandomTxt.text = random.Name;
        peopleRandomTxt.gameObject.SetActive(false);

        foreach (MainStructure people in PeoplesList.peoplelist)
        {
            if (people.Name == peopleRandomTxt.text)
            {
                peopleRandomInfo.Add("Name", people.Name);
                peopleRandomInfo.Add("Job", people.Job);
                peopleRandomInfo.Add("Age", people.Age);
                peopleRandomInfo.Add("Size", people.Size);
                peopleRandomInfo.Add("Nationality", people.Nationality);
            }
        }
     }

    public void checkSearchField(InputField search, Text answerslist)
    {
        if(search.text != null && !answerslist.text.Contains(search.text))
        {
            foreach(MainStructure people in PeoplesList.peoplelist)
            {
                if(people.Name == search.text)
                {
                    compareCorrectPerson(search, answerslist);
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

    public void compareCorrectPerson(InputField search, Text result)
    {
        var ageObject = peopleRandomInfo["Age"].ToString();
        var sizeObject = peopleRandomInfo["Size"].ToString();

        int age = Int32.Parse(ageObject);
        float size = float.Parse(sizeObject);

        foreach (MainStructure people in PeoplesList.peoplelist)
        {
            if (people.Name.Contains(search.text)) 
            {
                if (peopleRandomInfo.ContainsValue(people.Name))
                {
                    result.text += search.text + " == ";
                }
                else
                {
                    result.text += search.text + " != ";
                }

                if (age > people.Age)
                {
                    result.text += people.Age + " ++ ";
                } 
                else if (age < people.Age)    
                {
                    result.text += people.Age + " -- ";
                }
                else
                {
                    result.text += people.Age + " == ";
                }

                if (peopleRandomInfo.ContainsValue(people.Job))
                {
                    result.text += people.Job + " == ";
                }
                else
                {
                    result.text += people.Job + " != ";
                }
                if (peopleRandomInfo.ContainsValue(people.Nationality))
                {
                    result.text += people.Nationality + " == ";
                } 
                else
                {
                    result.text += people.Nationality + " != ";
                }
                if (size > people.Size)
                {
                    result.text += people.Size + " ++ \n";
                }
                else if(size < people.Size) 
                {
                    result.text += people.Size + " -- \n";
                }
                else
                {
                    result.text += people.Size + " == \n";
                }
                {

                }
            }
         

        }
    }

    public void BackToMainMenu()
    {
        Application.LoadLevel("MAINMENU");
    }
    


}
