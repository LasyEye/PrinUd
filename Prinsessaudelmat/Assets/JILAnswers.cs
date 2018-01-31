using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JILAnswers : MonoBehaviour {

    public int AnswerNumber = -1;



    List<string> answer = new List<string>() { "First answer", "Second answer", "Third answer", "Fourth answer" };



    // Use this for initialization
    void Start()
    {
        GetComponent<TextMesh>().text = answer[AnswerDealer()];
    }

    // Update is called once per frame
    void Update()
    {

    }



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
}
