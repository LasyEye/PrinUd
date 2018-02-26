using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JILAnswers : MonoBehaviour {

    //  By Joonas Luhtaniemi

    public int AnswerNumber;
    public int OrderNumber;

    public static bool answersEnabled = true;
    public static bool RandomizeOn = false;

    System.Random rnd = new System.Random();

    // Use this for initialization
    void Start()
    {
        randomizeAnswerNumbers();
    }

    // Update is called once per frame
    void Update()
    {
        if (JILGameManager.randomQuestion > -1)
        {
            if (AnswerNumber == 1)
            {
                GetComponent<TextMesh>().text = RightAnswer();
            }

            if (AnswerNumber == 2)
            {
                GetComponent<TextMesh>().text = WrongAnswer1();
            }

            if (AnswerNumber == 3)
            {
                GetComponent<TextMesh>().text = WrongAnswer2();
            }

            if (AnswerNumber == 4)
            {
                GetComponent<TextMesh>().text = WrongAnswer3();
            }
        }
    }

    public void randomizeAnswerNumbers()
    {
        int rndStart;
        rndStart = rnd.Next(1, 5);

        //rndStart = UnityEngine.Random.Range(0, 5);

        for (int i = 0; i < 5; i++)
        {
            if (rndStart == 5)
            {
                rndStart = 1;
            }

            if (OrderNumber == i)
            {
                AnswerNumber = rndStart;
            }

            rndStart += 1;
        }
    }

    void OnMouseDown()
    {
        if (answersEnabled == true)
        {
            JILGameManager.selectedAnswer = AnswerNumber.ToString();
            JILGameManager.choiseDone = "y";
        }
        
        if (JILGameManager.selectedAnswer == "1")
        {
            answersEnabled = false;
        }
    }

    private static string RightAnswer()
    {
        List<string> option = new List<string>() {
            //  1
            "Right1",
            //  2
            "Right2",
            //  3
            "Right3",
            //  4
            "Right4",
            //  5
            "Right5"
        };
        return option[JILGameManager.randomQuestion];
    }

    private static string WrongAnswer1()
    {
        List<string> option = new List<string>() {
            //  1
            "Wrong21", 
            //  2
            "Wrong22", 
            //  3
            "Wrong23", 
            //  4
            "Wrong24", 
            //  5
            "Wrong25",
        };
        return option[JILGameManager.randomQuestion];
    }

    private static string WrongAnswer2()
    {
        List<string> option = new List<string>() {
            //  1
            "Wrong31", 
            //  2
            "Wrong32", 
            //  3
            "Wrong33", 
            //  4
            "Wrong34", 
            //  5
            "Wrong35",
        };
        return option[JILGameManager.randomQuestion];
    }

    private static string WrongAnswer3()
    {
        List<string> option = new List<string>() {
            //  1
            "Wrong41", 
            //  2
            "Wrong42", 
            //  3
            "Wrong43", 
            //  4
            "Wrong44", 
            //  5
            "Wrong45",
        };
        return option[JILGameManager.randomQuestion];
    }

}
