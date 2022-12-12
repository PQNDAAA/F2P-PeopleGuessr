using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    public void ShowPanelGameObject()
    {
        this.transform.parent.gameObject.SetActive(true);
    }
}
