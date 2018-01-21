using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public Enemy enemyInfo;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    public float speed;
    private float timeToChangeDirection;
    public bool IsRunning;

    public int damage;
    public int life = 0;
    private int lifeBefore;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        ChangeDirection();
        speed = 0.75f;
        damage = enemyInfo.damage;
        life = enemyInfo.life;
        lifeBefore = life;
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

        if (life < lifeBefore)
        {
            StartCoroutine(FlashSprites());
        }

        lifeBefore = life;
    }

    IEnumerator FlashSprites()
    {
        Color c = new Color32(255, 0, 0, 155); //edit r,g,b and the alpha values to what you want
        for (var n = 0; n < 5; n++)
        {
            GetComponentInChildren<SpriteRenderer>().color = Color.white;
            yield return new WaitForSeconds(0.1f);
            GetComponentInChildren<SpriteRenderer>().color = c;
            yield return new WaitForSeconds(0.1f);
        }
        GetComponentInChildren<SpriteRenderer>().color = Color.white;
        if (life <= 0)
        {
            Drop();
        }
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

    private void Drop()
    {
        if (Random.Range(0, 100) > 80 && enemyInfo.drops.Length>0)
        {
            GameObject drop = Instantiate(enemyInfo.drops[Random.Range(0, enemyInfo.drops.Length)], transform.position, transform.rotation);
        }
        GameObject.Find("Spawner_Coyote").GetComponent<SpawnerScript>().removeCoyote(this.gameObject);
        Destroy(this.gameObject);
    }
}
