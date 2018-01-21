using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarControler : MonoBehaviour {

    private Image bar;
    private float health;

	// Use this for initialization
	void Start () {
        bar = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (bar == null)
        {
            return;
        }
        float lastHealth = health;
        health = LifeBarManager.instance.remainingLife;

        if(health != lastHealth)
        {
            bar.fillAmount = health / LifeBarManager.MAX_LIFE_LEVEL;
        }
	}
}
