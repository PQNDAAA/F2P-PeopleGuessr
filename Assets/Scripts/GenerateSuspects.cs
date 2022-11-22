using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateSuspects : MonoBehaviour
{
    //------------------
    public GameObject[] preImage;
    public Transform[] gizmos;

    //------------------
    public Text suspects;
    public PeoplesList peopleslist;

    //------------------
    public void Generate()
    {
        int random = 0;
        for (int i = 0; i < 4; i++)
        {
            random = UnityEngine.Random.Range(0, peopleslist.peoplel.peoples.Count);

            foreach (MainStructure.People people in peopleslist.peoplel)
            {
                if (people.Index == random && !suspects.text.Contains(people.Name))
                {
                    suspects.text += " " + people.Name;

                    for (int j = 0; j < preImage.Length; j++)
                    {
                        if (people.Name == preImage[j].gameObject.tag)
                        {
                            Debug.Log(Screen.currentResolution);

                            float x, y, z;

                            x = Random.Range(gizmos[2].position.x, gizmos[3].position.x);
                            y = Random.Range(gizmos[0].position.y, gizmos[1].position.y);
                            z = 0;


                            Vector3 randomPosition = new Vector3(x,y,z);
                            Debug.Log(randomPosition);
                            Instantiate(preImage[j], randomPosition,
                                Quaternion.identity,transform);

                            
                        }
                    }
                }
            }
        }
    }
   
}
