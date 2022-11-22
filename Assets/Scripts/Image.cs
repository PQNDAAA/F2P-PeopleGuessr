using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image : MonoBehaviour
{
    //public GameObject canvas;
    public GameObject imagePre;
    
    GameObject canvas;

    // Use this for initialization
    void Start()
    {
        canvas = GetComponent<GameObject>();

      Instantiate(imagePre,transform.position,transform.rotation,transform);
        Instantiate(imagePre, new Vector3(transform.position.x + 100, transform.position.y,transform.position.z), 
            transform.rotation, transform);
    }
}
