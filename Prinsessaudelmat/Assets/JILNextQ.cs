﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JILNextQ : MonoBehaviour {

    public static bool nextEnabled = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (nextEnabled == true)
        {
            nextEnabled = false;
            JILAnswers.answersEnabled = true;
            JILGameManager.randomQuestion = -1;
        }
    }
}
