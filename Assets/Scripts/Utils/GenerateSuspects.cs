using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GenerateSuspects : MonoBehaviour
{
    //------------------
    public GameObject[] preImage;
    public Transform[] gizmos;

    //------------------
    public PeoplesList peopleslist;

    //------------------
    public Dictionary<int, string> suspectslist = new Dictionary<int, string>();
    public Dictionary<int, string> trueSuspectNameIndex = new Dictionary<int, string>(); 
    public Dictionary <string, string> suspectCharacteristics = new Dictionary<string, string>();

    public int maxTries = 5;
    public int tries = 0;
    public void Generate()
    {
        int random = 0;

        while(tries < maxTries) { 

                random = UnityEngine.Random.Range(0, peopleslist.peoplel.peoples.Count);

                foreach (MainStructure people in peopleslist.peoplel.ToList())
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
                            }
                        }
                        tries++;
                    }
                }
        }
    }

    public void TrueSuspect()
    {
        System.Random random = new System.Random();
        int index = random.Next(suspectslist.Count);

        KeyValuePair<int, string> pair = suspectslist.ElementAt(index);

        trueSuspectNameIndex.Add(pair.Key, pair.Value);

        foreach(MainStructure truesuspect in peopleslist.peoplel)
        {
            if (truesuspect.Name == pair.Value)
            {
                suspectCharacteristics.Add("Hair", truesuspect.Hair);
                suspectCharacteristics.Add("Tatoos", truesuspect.Tatoos.ToString());
                suspectCharacteristics.Add("Tshirt", truesuspect.Tshirt);
                suspectCharacteristics.Add("Glasses", truesuspect.Glasses.ToString());
                suspectCharacteristics.Add("Backpack", truesuspect.Backpack.ToString());
            }
        }
        Debug.Log(pair.Value);
    }
   
}
