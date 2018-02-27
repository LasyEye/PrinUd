using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XNext : MonoBehaviour {

    public static bool nextEnabled = false;

    private void OnMouseDown()
    {
        if (nextEnabled == true)
        {
            nextEnabled = false;
            XGameManager.RemoveNumberFromList();
            //XGameManager.RemoveFromList();
            //XAnswers.RemoveFromLists();
            XAnswers.answersEnabled = true;
            XGameManager.randomQuestion = -1;
            if (XGameManager.unansweredQuestionNumbers.Count <= 0)
            {
                SceneManager.LoadScene("End");
            }
        }
    }
}
