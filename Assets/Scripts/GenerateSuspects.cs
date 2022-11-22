using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateSuspects : MonoBehaviour
{
    //------------------
    public GameObject[] preImage;
    //------------------
    public Text suspects;
    public PeoplesList peopleslist;

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
                            Instantiate(preImage[j], new Vector3(transform.position.x + 100,
                                transform.position.y, transform.position.z),
                                transform.rotation, transform);
                        }
                    }
                }
            }
        }
    }
   
}
