using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginningScript : MonoBehaviour {

    // Use this for initialization
    public void Run()
    {
        StartCoroutine(RunScript());
    }

    private IEnumerator RunScript()
    {
        int i = 75;
        while(i>0)
        {
            yield return new WaitForSeconds(.05f);
            GameObject.Find("Player").GetComponent<PlayerScript>().PlayerMoveRight();
            AudioManager.instance.Play("SandWalk");
            i--;
        }
            yield return new WaitForSeconds(2);
        AudioManager.instance.Stop("SandWalk");
        GameObject.Find("InputManager").GetComponent<InputManager>().isBeginningRunning = false;
    }
}
