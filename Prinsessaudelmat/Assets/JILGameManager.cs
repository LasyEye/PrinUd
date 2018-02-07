using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JILGameManager : MonoBehaviour {



    //  By Joonas Luhtaniemi



    List<string> questions = new List<string>() { "First Question", "Second Question", "Third Question", "Fourth Question", "Fifth Question" };

    public static int randomQuestion = -1;

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
            randomQuestion = Random.Range(0, 5);
        }
        
        if (randomQuestion > -1)
        {
            GetComponent<TextMesh>().text = questions[randomQuestion];
        }
        //Debug.Log(questions [randomQuestion]);
    }
}
