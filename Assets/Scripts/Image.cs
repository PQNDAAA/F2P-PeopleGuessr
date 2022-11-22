using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image : MonoBehaviour
{
    //public GameObject canvas;
    public GameObject[] imagePre;
    
    GameObject canvas;

    // Use this for initialization
    void Start()
    {
        canvas = GetComponent<GameObject>();


        /*GameObject imgObject = new GameObject("testAAA");
        RectTransform trans = imgObject.AddComponent<RectTransform>();
        trans.anchoredPosition = new Vector2(0.5f, 0.5f);
        trans.localPosition = new Vector3(0, 0, 0);
        trans.position = new Vector3(0, 0, 0);
        Image image = imgObject.AddComponent<Image>();
        Texture2D tex = Resources.Load<Texture2D>("red");
        image.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        imgObject.transform.SetParent(canvas.transform);*/
/*       Instantiate(imagePre,transform.position,transform.rotation,transform);
        Instantiate(imagePre, new Vector3(transform.position.x + 100, transform.position.y,transform.position.z), 
            transform.rotation, transform);*/
    }
}
