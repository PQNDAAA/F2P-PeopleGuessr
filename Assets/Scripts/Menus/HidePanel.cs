using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanel : MonoBehaviour
{
    //Function who hide the parent panel like the button "Back" for example is a children
    public void HidePanelGameObject()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
