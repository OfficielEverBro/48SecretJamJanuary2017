using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject.Find("ActionButton1").GetComponent<Button>().onClick.Invoke();
            Debug.Log("test");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject.Find("ActionButton1").GetComponent<Button>().onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameObject.Find("ActionButton1").GetComponent<Button>().onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameObject.Find("ActionButton1").GetComponent<Button>().onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            GameObject.Find("ActionButton1").GetComponent<Button>().onClick.Invoke();
        }
    }
}
