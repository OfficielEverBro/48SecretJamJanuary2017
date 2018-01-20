using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    public float speed = 0f;

    // Use this for initialization
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = true;
            animator.SetBool("IsRunning", true);

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
            animator.SetBool("IsRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("IsRunning", false);
        }

        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector2.right * -speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            //wind
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(1,0) * speed);
        }
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            animator.SetTrigger("Die");
        }
    }
}
