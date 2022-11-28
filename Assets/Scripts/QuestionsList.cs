using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsList : MonoBehaviour {

    public IQuestionsList questionsList = new IQuestionsList();

    [System.Serializable]
    public class IQuestionsList : IEnumerable<QuestionsStructure>
    {
        public List<QuestionsStructure> questions;
        public IEnumerator<QuestionsStructure> GetEnumerator()
        {
            return questions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return questions.GetEnumerator();
        }
    }
}
