using UnityEngine;

[System.Serializable]
public struct QuestionsStructure
{
    public int index;
    public string question;
    public enum Answer {Glasses,Hair,Tshirt,Backpack,Tatoos}
    public Answer answer;
    public enum AnswerColor { Blue,Blond,Brown,Green,Red,Nothing}
    public AnswerColor color;
}
