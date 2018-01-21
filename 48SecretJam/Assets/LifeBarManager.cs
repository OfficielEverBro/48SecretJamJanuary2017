using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBarManager : MonoBehaviour {

    public static float MAX_LIFE_LEVEL = 100f;
    public static float MIN_LIFE_LEVEL = 0f;

    public static LifeBarManager instance;

    public float remainingLife = MAX_LIFE_LEVEL;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Decrease(float damages)
    {
        remainingLife -= damages;
        if(damages < 0f)
        {
            // todo:  end game stuff
        }
    }

    public void Increase(float health)
    {
        remainingLife += health;
        if(remainingLife > MAX_LIFE_LEVEL)
        {
            remainingLife = MAX_LIFE_LEVEL;
        }
    }
}
