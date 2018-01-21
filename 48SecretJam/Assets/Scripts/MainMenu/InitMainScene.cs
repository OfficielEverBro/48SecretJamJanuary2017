using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitMainScene : MonoBehaviour {

	// Use this for initialization
	private void Start()
    {
        FindObjectOfType<AudioManager>().StopAll();
        FindObjectOfType<AudioManager>().Play("MenuTheme");
    }
}
