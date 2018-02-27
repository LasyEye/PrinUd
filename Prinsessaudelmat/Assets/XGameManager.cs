using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XGameManager : MonoBehaviour {

    List<string> questions = new List<string>() {
        //  1
        "First Question",
        //  2
        "Second Question",
        //  3
        "Third Question",
        //  4
        "Fourth Question",
        //  5
        "Fifth Question"
    };

    List<string> rightAnswers = new List<string>() {
        //  1
        "1",
        //  2
        "1",
        //  3
        "1",
        //  4
        "1",
        //  5
        "1"
    };

    public static int score = 0;

    public static string selectedAnswer;

    public static string rightAnswer;

    public static string choiseDone = "n";

    public static int randomQuestion = -1;

    public Transform resultObj;

    public Transform scoreObj;

    //private static List<string> unansweredQuestions;

    // Use this for initialization
    void Start () {

        GetComponent<TextMesh>().text = questions[0];

        /*
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions;
        }
        */
    }
	
	// Update is called once per frame
	void Update () {

        if (randomQuestion == -1)
        {
            randomQuestion = Random.Range(0, questions.Count);    // alt.max: unansweredQuestions.Count
            GetComponent<TextMesh>().text = questions[randomQuestion];
            rightAnswer = rightAnswers[randomQuestion];
            //XAnswers.setAnswers = true;
        }

        if (choiseDone == "y")
        {
            choiseDone = "n";

            if (selectedAnswer == rightAnswer)
            {
                score += 1;
                resultObj.GetComponent<TextMesh>().text = "Correct!";
                scoreObj.GetComponent<TextMesh>().text = score.ToString();
                XNext.nextEnabled = true;
            }
            else
            {
                if (score > 0)
                {
                    score -= 1;
                }
                resultObj.GetComponent<TextMesh>().text = "Wrong...";
                scoreObj.GetComponent<TextMesh>().text = score.ToString();
            }
        }
    }

    /*
    public static void RemoveFromList()
    {
        unansweredQuestions.RemoveAt(randomQuestion);
    }
    */
}
