using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitNightScene : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        FindObjectOfType<AudioManager>().StopAll();
        FindObjectOfType<AudioManager>().Play("GameTheme");
        LifeBarManager.instance.remainingLife = 100;
        GameObject.Find("BeginningScript").GetComponent<BeginningScript>().Run();
    }
}
