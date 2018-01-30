using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControl : MonoBehaviour {



    List<string> questions = new List<string>()
    {
        //  First question
        "This is the first question."
    };



    // Use this for initialization
    void Start()
    {
        GetComponent<TextMesh>().text = questions[0];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
