using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GenerateSuspects : MonoBehaviour
{
    //------------------
    public GameObject[] preImage;
    public Transform[] gizmos;

    //------------------
    public PeoplesList peopleslist;

    //------------------
    public Dictionary<int, string> suspectslist = new Dictionary<int, string>();
    public void Generate()
    {
        int random = 0;
            for (int i = 0; i < 5; i++)
        {
                random = UnityEngine.Random.Range(0, peopleslist.peoplel.peoples.Count);

                foreach (MainStructure.People people in peopleslist.peoplel.ToList())
                {
                    if (people.Index == random && !suspectslist.ContainsKey(random))
                    {
                    suspectslist.Add(people.Index, people.Name);

                        for (int j = 0; j < preImage.Length; j++)
                        {
                            if (people.Name == preImage[j].gameObject.tag)
                            {
                            float x, y, z;

                            x = Random.Range(gizmos[2].position.x, gizmos[3].position.x);
                            y = Random.Range(gizmos[0].position.y, gizmos[1].position.y);
                            z = 0;


                            Vector3 randomPosition = new Vector3(x, y, z);
                            Debug.Log(randomPosition);
                            Instantiate(preImage[j], randomPosition,
                                Quaternion.identity, transform);

                            peopleslist.peoplel.peoples.Remove(people);
                        }
                        }
                } 
            }
        }
    }

    public void TrueSuspect()
    {
        System.Random random = new System.Random();
        int index = random.Next(suspectslist.Count);

        foreach(var s in suspectslist)
        {
            Debug.Log("Suspects :" + s);
        }

        KeyValuePair<int, string> pair = suspectslist.ElementAt(index);

        Debug.Log(pair.Value);
    }
   
}
