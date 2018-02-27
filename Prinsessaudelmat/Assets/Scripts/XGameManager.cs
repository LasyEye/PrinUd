using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XGameManager : MonoBehaviour {

    List<string> questions = new List<string>() {
        //  1
        @"What is the knights
greatest quality?",
        //  2
        @"Are you wealthy?",
        //  3
        @"Do you own a horse?",
        //  4
        @"What would you request
as a reward for saving me?",
        //  5
        @"What is your name?"
    };

    List<string> rightAnswers = new List<string>() {
        //  1
        "4",
        //  2
        "3",
        //  3
        "3",
        //  4
        "1",
        //  5
        "2"
    };

    public static List<int> unansweredQuestionNumbers = new List<int>() {
        0, 1, 2, 3, 4,
    };

    public static int randomListNum;

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
            randomListNum = Random.Range(0, unansweredQuestionNumbers.Count);
            //randomQuestion = Random.Range(0, questions.Count);    // alt.max: unansweredQuestions.Count
            randomQuestion = unansweredQuestionNumbers[randomListNum];
            GetComponent<TextMesh>().text = questions[randomQuestion];
            rightAnswer = rightAnswers[randomQuestion];
            XAnswers.setAnswers = true;
        }

        if (choiseDone == "y")
        {
            choiseDone = "n";

            if (selectedAnswer == rightAnswer)
            {
                score += 1;
                resultObj.GetComponent<TextMesh>().text = "Lovely!";
                scoreObj.GetComponent<TextMesh>().text = score.ToString();
                XNext.nextEnabled = true;
                StartCoroutine(TalkReset());
            }
            else
            {
                if (score > 0)
                {
                    score -= 1;
                }
                resultObj.GetComponent<TextMesh>().text = "Hmmm...";
                scoreObj.GetComponent<TextMesh>().text = score.ToString();
                StartCoroutine(TalkReset());
            }
        }
    }

    private IEnumerator TalkReset()
    {
        yield return new WaitForSeconds(2);
        resultObj.GetComponent<TextMesh>().text = "...";
    }

    public static void RemoveNumberFromList()
    {
        unansweredQuestionNumbers.RemoveAt(randomListNum);
    }

    /*
    public static void RemoveFromList()
    {
        unansweredQuestions.RemoveAt(randomQuestion);
    }
    */
}
