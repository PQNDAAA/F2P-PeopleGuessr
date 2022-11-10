using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchSystem : MonoBehaviour
{
    public InputField searchField;
    public Text Answers;
    public Utilities utils;

    public void OnClickHandler()
    {
        utils.checkSearchField(searchField, Answers);
    }
}
