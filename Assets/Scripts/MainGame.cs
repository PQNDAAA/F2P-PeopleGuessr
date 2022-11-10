using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{

    public Utilities utils;

    void Start()
    {
        utils.RandomPeople();
    }
}
