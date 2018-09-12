﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour {

    private Light myLight;

	void Start () {
        myLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(key: KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
	}
}
