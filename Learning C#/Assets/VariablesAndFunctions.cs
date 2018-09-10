using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour {

    int myInt = 55;

	// Use this for initialization
	void Start () {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
	}

    int MultiplyByTwo(int number) {
        int ret;
        ret = number * 2;

        return ret;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
