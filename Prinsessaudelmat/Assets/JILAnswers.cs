using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JILAnswers : MonoBehaviour {

    public int AnswerNumber = -1;



    List<string> answer = new List<string>() { RightAnswer(), WrongAnswer1(), WrongAnswer2(), WrongAnswer3() };



    // Use this for initialization
    void Start()
    {
        //GetComponent<TextMesh>().text = answer[AnswerDealer()];
    }

    // Update is called once per frame
    void Update()
    {
        if (JILGameManager.randomQuestion > -1)
        {
            GetComponent<TextMesh>().text = answer[JILGameManager.randomQuestion];
        }
    }



    private static string RightAnswer()
    {
        return "right1";
    }

    private static string WrongAnswer1()
    {
        return "wrong1";
    }

    private static string WrongAnswer2()
    {
        return "wrong2";
    }

    private static string WrongAnswer3()
    {
        return "wrong3";
    }


    /*
    private int AnswerDealer()
    {
        int AnswerOption = -1;

        if (AnswerNumber == 1)
        {
            AnswerOption = 0;
        }
        else if (AnswerNumber == 2)
        {
            AnswerOption = 1;
        }
        else if (AnswerNumber == 3)
        {
            AnswerOption = 2;
        }
        else if (AnswerNumber == 4)
        {
            AnswerOption = 3;
        }
        else
        {
            Debug.Log("Answer dealer error!");
        }

        return AnswerOption;
    }
    */
}
