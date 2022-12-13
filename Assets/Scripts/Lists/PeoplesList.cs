using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeoplesList : MonoBehaviour
{

    //Create a global list for all peoples 
    public CreatePeopleList globalPeoplesList = new CreatePeopleList();

    [System.Serializable]

    //Create a specific list for each person with each caracteristics
    public class CreatePeopleList : IEnumerable<MainStructure>
    {
        public List<MainStructure> peopleList;

        public IEnumerator<MainStructure> GetEnumerator()
        {
            return peopleList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return peopleList.GetEnumerator();
        }
    }
}
