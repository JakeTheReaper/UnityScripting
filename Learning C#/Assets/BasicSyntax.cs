using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        } else
        {
            Debug.Log("I am way too high, I'm FLYING!");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
