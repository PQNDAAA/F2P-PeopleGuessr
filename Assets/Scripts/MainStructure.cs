using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainStructure : MonoBehaviour
{

    public int Index { get; set; }
    public string Name { get; set; }
    public string Job { get; set; }
    public int Age { get; set; }
    public float Size { get; set; }
    public string Nationality { get; set; }


    public MainStructure(int index, string name, string job, int age, float size, string nationality)
    {
        this.Index = index;
        this.Name = name;
        this.Job = job;
        this.Age = age;
        this.Size = size;
        this.Nationality = nationality;
    }

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
