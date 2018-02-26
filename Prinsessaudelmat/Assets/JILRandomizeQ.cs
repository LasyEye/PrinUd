using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JILRandomizeQ : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //randomAnsw();

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    /*
    public static void randomAnsw()
    {
        int randStart = Random.Range(1, 5);

        GameObject Answer = GameObject.Find("Answer");
        JILAnswers jAnswers = Answer.GetComponent<JILAnswers>();

        for (int i = 1; i < 4; i++)
        {
            if (randStart > 4)
            {
                randStart = 1;
            }
            if (jAnswers.OrderNumber == i)
            {
                jAnswers.AnswerNumber = randStart;
            }
            randStart += 1;
        }
    }
    */

    /*
    public static void randAnsw()
    {
        int randStart = Random.Range(0, 5);

        for (int i = 1; i < 5; i++)
        {
            if (randStart > 4)
            {
                randStart = 1;
            }
            if (JILAnswers.sOrderNumber == i)
            {
                JILAnswers.sAnswerNumber = randStart;
            }
            randStart += 1;
        }
    }
    */
}
