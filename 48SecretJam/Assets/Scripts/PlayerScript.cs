using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Animator animatorA;
    private Animator animatorP;
    private SpriteRenderer spriteRendererP;
    private SpriteRenderer spriteRendererA;
    public float speed = 0f;

    public bool rightDown;
    public bool leftDown;
    public bool isGrounded;

    public int damage = 10;
    public bool isDead = false;

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

        if (isDead)
            LifeBarManager.instance.Decrease(100);

        if(rightDown || leftDown)
            animatorP.SetBool("IsRunning", true);
        else
            animatorP.SetBool("IsRunning", false);
    }

    public void PlayerMoveRight()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        spriteRendererP.flipX = false;
        spriteRendererA.flipX = false;
        spriteRendererA.transform.localPosition = new Vector3(0.6f, 0.3f);
    }

    public void PlayerMoveLeft()
    {
        transform.Translate(Vector2.right * -speed * Time.deltaTime);
        spriteRendererP.flipX = true;
        spriteRendererA.flipX = true;
        spriteRendererA.transform.localPosition = new Vector3(-0.6f, 0.3f);
    }

    public void PlayerJump()
    {
        if (isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            isGrounded = false;
            AudioManager.instance.Stop("SandWalk");
        }
    }

    public void PlayerAttack()
    {
        if (!animatorA.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            animatorA.Play("Attack");
        }
        List<EnemyScript> e = GetComponentInChildren<PlayerAttack>().enemyList;
        AudioManager.instance.Stop("Hit");
        AudioManager.instance.Play("Hit");
        foreach (EnemyScript enemy in e)
        {
            enemy.life -= damage;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GroundTag")
        {
            isGrounded = true;
            AudioManager.instance.Stop("SandWalk");
        }
    }
}
