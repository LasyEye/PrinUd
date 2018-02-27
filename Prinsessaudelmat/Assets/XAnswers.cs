using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XAnswers : MonoBehaviour {

    List<string> option1 = new List<string>()
    {
        //  1
        "Right1-1",
        //  2
        "Right1-2",
        //  3
        "Right1-3",
        //  4
        "Right1-4",
        //  5
        "Right1-5"
    };

    List<string> option2 = new List<string>() {
        //  1
        "Wrong2-1", 
        //  2
        "Wrong2-2", 
        //  3
        "Wrong2-3", 
        //  4
        "Wrong2-4", 
        //  5
        "Wrong2-5",
    };

    List<string> option3 = new List<string>() {
        //  1
        "Wrong3-1", 
        //  2
        "Wrong3-2", 
        //  3
        "Wrong3-3", 
        //  4
        "Wrong3-4", 
        //  5
        "Wrong3-5",
    };

    List<string> option4 = new List<string>() {
        //  1
        "Wrong4-1", 
        //  2
        "Wrong4-2", 
        //  3
        "Wrong4-3", 
        //  4
        "Wrong4-4", 
        //  5
        "Wrong4-5",
    };

    /*
     private static List<string> UNoption1;

    private static List<string> UNoption2;

    private static List<string> UNoption3;

    private static List<string> UNoption4;
    */

    public int AnswerNumber;

    public static bool answersEnabled = true;

    //public static bool setAnswers = false;

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

        /*
        if (setAnswers == true)
        {
            if (AnswerNumber == 1)
            {
                GetComponent<TextMesh>().text = option1[JILGameManager.randomQuestion];
            }

            if (AnswerNumber == 2)
            {
                GetComponent<TextMesh>().text = option2[JILGameManager.randomQuestion];
            }

            if (AnswerNumber == 3)
            {
                GetComponent<TextMesh>().text = option3[JILGameManager.randomQuestion];
            }

            if (AnswerNumber == 4)
            {
                GetComponent<TextMesh>().text = option4[JILGameManager.randomQuestion];
            }
        }
        */
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
