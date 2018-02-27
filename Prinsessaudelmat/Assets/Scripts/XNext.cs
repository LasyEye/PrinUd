using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XNext : MonoBehaviour {

    public static bool nextEnabled = false;

    private void OnMouseDown()
    {
        if (nextEnabled == true)
        {
            nextEnabled = false;
            //XGameManager.RemoveFromList();
            //XAnswers.RemoveFromLists();
            XAnswers.answersEnabled = true;
            XGameManager.randomQuestion = -1;
        }
    }
}
