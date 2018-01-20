using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    public float speed = 0f;

    private bool rightDown;
    private bool leftDown;

    // Use this for initialization
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        rightDown = false;
        leftDown = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            leftDown = true;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rightDown = true;
        if (Input.GetKeyUp(KeyCode.RightArrow))
            rightDown = false;
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            leftDown = false;

        if(rightDown || leftDown)
            animator.SetBool("IsRunning", true);
        else
            animator.SetBool("IsRunning", false);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
            spriteRenderer.flipX = true;
        }

        /*if (Input.GetKey(KeyCode.A))
        {
            //wind
            GetComponent<Rigidbody2D>().AddForce(new Vector2(1,0) * speed);
        }*/
        
    }
}
