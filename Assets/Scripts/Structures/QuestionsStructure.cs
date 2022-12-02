[System.Serializable]
public struct QuestionsStructure
{
    public int index;
    public string question;

    public enum Answer {Glasses,Hair,Tshirt,Backpack,Tatoos}
    public enum AnswerColor { Blue, Blond, Brown, Green, Red, Nothing }

    public Answer answer;
    public AnswerColor color;
}
