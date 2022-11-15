using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainStructure : MonoBehaviour
{
    [System.Serializable]
    public class People
    {
        public int Index;
        public string Name;
        public string Job;
        public int Age;
        public float Size;
        public string Nationality;
    }

}
