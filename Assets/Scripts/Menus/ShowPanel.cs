using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    //Function who show the parent panel like the button "Back" for example is a children
    public void ShowPanelGameObject()
    {
        this.transform.parent.gameObject.SetActive(true);
    }
}
