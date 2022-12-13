using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GenerateSuspects : MonoBehaviour
{
    //------------------
    //Get the lines "borders"
    public GameObject[] preImage;
    public Transform[] gizmos;
    //------------------
    public Utilities utils;
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

            //Each time the game takes a random index 
                random = UnityEngine.Random.Range(0, utils.referencePeopleList.globalPeoplesList.peopleList.Count);

                foreach (MainStructure people in utils.referencePeopleList.globalPeoplesList.ToList())
                {
                //The game compares the random index with the peoples indexs
                    if (people.Index == random && !suspectslist.ContainsKey(random))
                    {
                    //if true then the game adds in the suspects list 
                        suspectslist.Add(people.Index, people.Name);

                        for (int j = 0; j < preImage.Length; j++)
                        {
                            if (people.Name == preImage[j].gameObject.tag)
                            {
                                float x, y, z;

                            //I get the borders on the map to define a limit to avoid conflicts with elements 
                                x = Random.Range(gizmos[2].position.x, gizmos[3].position.x);
                                y = Random.Range(gizmos[0].position.y, gizmos[1].position.y);
                                z = 0;

                            //The game summons it on the map to a random location on the phone screen 
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

        //I created a KeyValuePair to recover the true elements of the suspect selected by the variable "index" just on the top 
        KeyValuePair<int, string> pair = suspectslist.ElementAt(index);

        //I added the index and the suspect name in the dictionnary
        trueSuspectNameIndex.Add(pair.Key, pair.Value);

        foreach(MainStructure truesuspect in utils.referencePeopleList.globalPeoplesList)
        {
            if (truesuspect.Name == pair.Value)
            {
                //Then I added caracteristics in the other dictionnary 
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
