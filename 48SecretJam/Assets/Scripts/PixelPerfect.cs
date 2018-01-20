using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        GetComponent<Camera>().orthographicSize = Screen.height / 2;
    }
}
