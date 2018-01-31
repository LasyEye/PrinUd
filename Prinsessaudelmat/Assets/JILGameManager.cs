using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JILGameManager : MonoBehaviour {



    //  By Joonas Luhtaniemi



    List<string> questions = new List<string>() { "First Question" };



	// Use this for initialization
	void Start ()
    {
        GetComponent<TextMesh>().text = questions[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
