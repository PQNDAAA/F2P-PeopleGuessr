using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeoplesList : MonoBehaviour
{

    public static List<CreatePeoplesList> peoplelist = new List<CreatePeoplesList>
    {
        new CreatePeoplesList(0,"Jean","null",45,1.75f,"Espana"),
        new CreatePeoplesList(1,"Gerard","null",26,1.86f,"Japan"),
        new CreatePeoplesList(2,"Charline","null",20,1.66f,"Argentina")
    };
}
