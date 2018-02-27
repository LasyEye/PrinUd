using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XAnswers : MonoBehaviour {

    List<string> option1 = new List<string>()
    {
        //  1
        @"Bravery!",
        //  2
        @"Yes.",
        //  3
        @"I have a donkey...",
        //  4
        @"Your hand.",
        //  5
        @"Ser Bob."
    };

    List<string> option2 = new List<string>() {
        //  1
        @"His wits.", 
        //  2
        @"No.", 
        //  3
        @"Multiple.", 
        //  4
        @"Your leg.", 
        //  5
        @"Ser Bo*COUGH* Percival."
    };

    List<string> option3 = new List<string>() {
        //  1
        @"Strength!!!", 
        //  2
        @"Extremely.", 
        //  3
        @"Yes, and it is sooo cute!",
        //  4
        @"Your head.", 
        //  5
        @"Ser Bo*COUGH* Tom... Damn..."
    };

    List<string> option4 = new List<string>() {
        //  1
        @"Long sword. ;)", 
        //  2
        @"Some day I will be...", 
        //  3
        @"I repeatedly hit
coconut halves together.", 
        //  4
        @"Dat posterior.", 
        //  5
        @"Ser Bo*COUGH...COUGH! COUGH!*
*Wheeeeeze...*"
    };

    /*
     private static List<string> UNoption1;

    private static List<string> UNoption2;

    private static List<string> UNoption3;

    private static List<string> UNoption4;
    */

    public int AnswerNumber;

    public static bool answersEnabled = true;

    public static bool setAnswers = false;

    // Use this for initialization
    void Start () {

        /*
        if (UNoption1 == null || UNoption1.Count == 0)
        {
            UNoption1 = option1;
        }

        if (UNoption2 == null || UNoption2.Count == 0)
        {
            UNoption2 = option2;
        }

        if (UNoption3 == null || UNoption3.Count == 0)
        {
            UNoption3 = option3;
        }

        if (UNoption4 == null || UNoption4.Count == 0)
        {
            UNoption4 = option4;
        }
        */
    }
	
	// Update is called once per frame
	void Update () {

        if (setAnswers == true)
        {
            if (AnswerNumber == 1)
            {
                GetComponent<TextMesh>().text = option1[XGameManager.randomQuestion];
            }

            if (AnswerNumber == 2)
            {
                GetComponent<TextMesh>().text = option2[XGameManager.randomQuestion];
            }

            if (AnswerNumber == 3)
            {
                GetComponent<TextMesh>().text = option3[XGameManager.randomQuestion];
            }

            if (AnswerNumber == 4)
            {
                GetComponent<TextMesh>().text = option4[XGameManager.randomQuestion];
            }
        }
    }

    /*
    public static void RemoveFromLists()
    {
        int eraser = JILGameManager.randomQuestion;
        UNoption1.RemoveAt(eraser);
        UNoption2.RemoveAt(eraser);
        UNoption3.RemoveAt(eraser);
        UNoption4.RemoveAt(eraser);
    }
    */

    void OnMouseDown()
    {
        if (answersEnabled == true)
        {
            XGameManager.selectedAnswer = AnswerNumber.ToString();
            XGameManager.choiseDone = "y";
        }

        if (XGameManager.selectedAnswer == XGameManager.rightAnswer)
        {
            answersEnabled = false;
        }
    }
}
