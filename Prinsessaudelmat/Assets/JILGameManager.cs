using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JILGameManager : MonoBehaviour {

    //  By Joonas Luhtaniemi

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

    public static int score = 0;

    public static string selectedAnswer;

    public static string choiseDone = "n";

    public static int randomQuestion = -1;

    public Transform resultObj;

    public Transform scoreObj;

	// Use this for initialization
	void Start ()
    {
        GetComponent<TextMesh>().text = questions[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (randomQuestion == -1)
        {
            randomQuestion = Random.Range(0, questions.Count);
        }
        
        if (randomQuestion > -1)
        {
            GetComponent<TextMesh>().text = questions[randomQuestion];
        }
        
        if (choiseDone == "y")
        {
            choiseDone = "n";

            if (selectedAnswer == "1")
            {
                score += 1;
                resultObj.GetComponent<TextMesh>().text = "Correct!";
                scoreObj.GetComponent<TextMesh>().text = score.ToString();
                JILNextQ.nextEnabled = true;
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
}
