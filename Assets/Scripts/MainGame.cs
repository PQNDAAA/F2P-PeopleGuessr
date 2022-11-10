using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{

    public Utilities utils;
    public GameObject WinUI;

    void Start()
    {
        utils.RandomPeople();
        WinUI.SetActive(false);
    }
}
