using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    private Animator animatorA;
    private Animator animatorP;
    private SpriteRenderer spriteRendererP;
    private SpriteRenderer spriteRendererA;
    public float speed = 0f;

    private bool rightDown;
    private bool leftDown;
    public bool isGrounded;

    // Use this for initialization
    void Start()
    {
        animatorA = GameObject.Find("attack").GetComponentInChildren<Animator>();
        animatorP = GameObject.Find("PlayerSprite").GetComponentInChildren<Animator>();
        spriteRendererA = GameObject.Find("attack").GetComponentInChildren<SpriteRenderer>();
        spriteRendererP = GameObject.Find("PlayerSprite").GetComponentInChildren<SpriteRenderer>();
        rightDown = false;
        leftDown = false;
        isGrounded = false;
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
            animatorP.SetBool("IsRunning", true);
        else
            animatorP.SetBool("IsRunning", false);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            spriteRendererP.flipX = false;
            spriteRendererA.flipX = false;
            spriteRendererA.transform.localPosition = new Vector3(0.6f, 0.3f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
            spriteRendererP.flipX = true;
            spriteRendererA.flipX = true;
            spriteRendererA.transform.localPosition = new Vector3(-0.6f,0.3f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
                isGrounded = false;
            }
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerDownHandler);
            animatorA.SetBool("Attack", true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerUpHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerExitHandler);
            animatorA.SetBool("Attack", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton2").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton2").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerDownHandler);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton2").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerUpHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton2").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerExitHandler);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton3").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton3").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerDownHandler);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton3").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerUpHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton3").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerExitHandler);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton4").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton4").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerDownHandler);
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton4").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerUpHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton4").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerExitHandler);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton5").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton5").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerDownHandler);
        }
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton5").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerUpHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton5").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerExitHandler);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GroundTag")
        {
            isGrounded = true;
        }
    }
}
