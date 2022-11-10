using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchSystem : MonoBehaviour
{
    public InputField searchField;
    public Text Answers;
    public Utilities utils;
    void Start()
    {
    }
    void Update()
    {

    }
    public void OnClickHandler()
    {
        utils.checkSearchField(searchField, Answers);
    }
}
