using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameControler : MonoBehaviour {

	void Start ()
    {
        AudioManager.instance.StopAll();
        AudioManager.instance.Play("EndGameTheme");
	}

    public void OnButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
}
