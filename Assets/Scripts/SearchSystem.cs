using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchSystem : MonoBehaviour
{
    public InputField searchField;
    public Text Answers;
    void Start()
    {
    }
    void Update()
    {

    }
    public void OnClickHandler()
    {
        Utilities utils = new Utilities();
        utils.checkSearchField(searchField, Answers);
    }
}
