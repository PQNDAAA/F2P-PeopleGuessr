using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanel : MonoBehaviour
{
    public void HidePanelGameObject()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
