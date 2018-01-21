using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoyoteScript : MonoBehaviour {

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    public float speed;
    private float timeToChangeDirection;
    public bool IsRunning;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        ChangeDirection();
        speed = 0.75f;
    }

    public void Update()
    {
        timeToChangeDirection -= Time.deltaTime;

        if (speed < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (speed > 0)
        {
            spriteRenderer.flipX = false;
        }


        if (timeToChangeDirection <= 0)
        {
            ChangeDirection();
        }

        if(IsRunning)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void ChangeDirection()
    {
        if (Random.Range(0, 10) > 5) {
            IsRunning = false;
            animator.SetBool("IsRunning", false);
        }
        else
        {
            IsRunning = true;
            speed = speed * -1;
            animator.SetBool("IsRunning", true);
        }
        timeToChangeDirection = 3f;
    }
}
