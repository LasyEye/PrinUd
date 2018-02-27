using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XEndscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = XGameManager.score.ToString();

    }
}
