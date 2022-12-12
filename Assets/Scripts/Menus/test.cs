using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public void testGoToMainMenu()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
