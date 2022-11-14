using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PeoplesList : MonoBehaviour
{
    public  CreatePeopleList peoplel = new CreatePeopleList();

    [SerializeField]
    public static List<MainStructure> peoplelist = new List<MainStructure>
    {
        new MainStructure(0,"Jean","Doctor",45,1.75f,"Espana"),
        new MainStructure(1,"Gerard","Mathematician",36,1.86f,"Japan"),
        new MainStructure(2,"Charline","Lawyer",20,1.66f,"Argentina")
    };

    [System.Serializable]

    public class CreatePeopleList
    {
        public List<MainStructure.People> peoples;
    }

}
