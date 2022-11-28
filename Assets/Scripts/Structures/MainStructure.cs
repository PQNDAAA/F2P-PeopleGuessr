using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class MainStructure : MonoBehaviour
{
    [System.Serializable]
    public class People
    {
        public int Index;
        public string Name;
        public string Hair;
        public bool Tatoos;
        public string Tshirt;
        public bool Glasses;
        public bool Backpack;
    }

}
