using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static MainStructure;
using Image = UnityEngine.UI.Image;

public class Utilities : MonoBehaviour
{
    public Text peopleRandomTxt;
    public GameObject GameUI;
    public GameObject WinUI;
    public PeoplesList peopleslist;

    public Text suspects;
    public Image imgsuspects;

    private Sprite img1;

    Dictionary<string, object> peopleRandomInfo = new Dictionary<string, object>();

    public void RandomPeople()
    {
        int random = 0;
        for(int i = 0; i < 4; i++)
        {
           random = UnityEngine.Random.Range(0, peopleslist.peoplel.peoples.Count);

            foreach (MainStructure.People people in peopleslist.peoplel)
            {
                if (people.Index == random && !suspects.text.Contains(people.Name))
                {
                    suspects.text += " " + people.Name;

                    Debug.Log(people.img);

                    GameObject MyImage = new GameObject();
                    MyImage.AddComponent(typeof(Image));
                    img1 = Resources.Load<Sprite>(people.img);
                    MyImage.GetComponent<Image>().sprite = img1;
                    Debug.Log("Test script started");

                }
            }

        }

        /*/
                foreach (MainStructure.People people in peopleslist.peoplel)
                {
                    if(people.Index == random)
                    {
                        peopleRandomTxt.text = people.Name;

                        peopleRandomInfo.Add("Name", people.Name);
                        peopleRandomInfo.Add("Job", people.Job);
                        peopleRandomInfo.Add("Age", people.Age);
                        peopleRandomInfo.Add("Size", people.Size);
                        peopleRandomInfo.Add("Nationality", people.Nationality);
                    }
                }
                peopleRandomTxt.gameObject.SetActive(true);
        /*/
    }

    public void checkSearchField(InputField search, Text answerslist)
    {
        if(search.text != null && !answerslist.text.Contains(search.text))
        {
            foreach (MainStructure.People people in peopleslist.peoplel)
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

        foreach (MainStructure.People people in peopleslist.peoplel)
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
