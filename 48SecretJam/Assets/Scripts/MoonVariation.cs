using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonVariation : MonoBehaviour {

    private Light flare;
    public float minRange;
    public float maxRange;
    public float speed;

    private bool goesUp;

    void Start()
    {
        flare = GetComponentInChildren<Light>();
        goesUp = false;
    }

    void Update()
    {
        if (flare.range <= minRange || flare.range >= maxRange)
            goesUp = !goesUp;

        if (goesUp)
        {
            flare.range = flare.range - speed/10;
            flare.intensity = flare.intensity - speed / 1000;
        }
        else
        {
            flare.range = flare.range + speed/10;
            flare.intensity = flare.intensity + speed / 1000;
        }

    }
}
