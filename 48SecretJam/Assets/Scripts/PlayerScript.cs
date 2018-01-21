using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerDownHandler);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerUpHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerExitHandler);
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
}
