using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsList : MonoBehaviour {

    //Create a global list for all questions
    public IQuestionsList globalQuestionsList = new IQuestionsList();

    [System.Serializable]

    //Create a specific list with each question 
    public class IQuestionsList : IEnumerable<QuestionsStructure>
    {
        public List<QuestionsStructure> questionsList;
        public IEnumerator<QuestionsStructure> GetEnumerator()
        {
            return questionsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return questionsList.GetEnumerator();
        }
    }
}
