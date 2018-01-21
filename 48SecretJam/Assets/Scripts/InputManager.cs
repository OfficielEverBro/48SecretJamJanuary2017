using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

    public bool isBeginningRunning = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(isBeginningRunning)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            GameObject.Find("Player").GetComponent<PlayerScript>().leftDown = true;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            GameObject.Find("Player").GetComponent<PlayerScript>().rightDown = true;
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GameObject.Find("Player").GetComponent<PlayerScript>().rightDown = false;
            AudioManager.instance.Stop("SandWalk");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GameObject.Find("Player").GetComponent<PlayerScript>().leftDown = false;
            AudioManager.instance.Stop("SandWalk");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GameObject.Find("Player").GetComponent<PlayerScript>().PlayerMoveRight();
            if (GameObject.Find("Player").GetComponent<PlayerScript>().isGrounded)
            {
                AudioManager.instance.Play("SandWalk");
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject.Find("Player").GetComponent<PlayerScript>().PlayerMoveLeft();
            if (GameObject.Find("Player").GetComponent<PlayerScript>().isGrounded)
            {
                AudioManager.instance.Play("SandWalk");
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Find("Player").GetComponent<PlayerScript>().PlayerJump();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerDownHandler);
            GameObject.Find("Player").GetComponent<PlayerScript>(). PlayerAttack();
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerUpHandler);
            ExecuteEvents.Execute(GameObject.Find("ActionButton1").GetComponent<Button>().gameObject, pointer, ExecuteEvents.pointerExitHandler);
            //animatorA.SetBool("Attack", false);
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
            GameObject.Find("ActionButton2").GetComponent<ActionButtonScript>().EmptyButton();
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
            GameObject.Find("ActionButton3").GetComponent<ActionButtonScript>().EmptyButton();
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
            GameObject.Find("ActionButton4").GetComponent<ActionButtonScript>().EmptyButton();
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
            GameObject.Find("ActionButton5").GetComponent<ActionButtonScript>().EmptyButton();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
