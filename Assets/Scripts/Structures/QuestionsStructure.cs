using UnityEngine;

[System.Serializable]
public struct QuestionsStructure
{
    public int index;
    public string question;
    public enum Answer {Glasses,Hair,Tshirt,Blond,Blue}
    public Answer answer;
}
