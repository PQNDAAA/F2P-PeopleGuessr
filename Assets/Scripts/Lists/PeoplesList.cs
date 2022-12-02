using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeoplesList : MonoBehaviour
{
    public CreatePeopleList peoplel = new CreatePeopleList();

    [System.Serializable]

    public class CreatePeopleList : IEnumerable<MainStructure>
    {
        public List<MainStructure> peoples;

        public IEnumerator<MainStructure> GetEnumerator()
        {
            return peoples.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return peoples.GetEnumerator();
        }
    }
}
