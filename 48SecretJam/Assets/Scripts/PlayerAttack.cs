using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public PlayerScript ps;
    public List<EnemyScript> enemyList;
    private void Start()
    {
        enemyList = new List<EnemyScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            /*CanHit = true;
            EnemyScript enemy = collision.gameObject.GetComponent<EnemyScript>();
            Debug.Log(enemy.life);
            enemy.life -= ps.damage;
            Debug.Log(enemy.life);*/
            enemyList.Add(collision.gameObject.GetComponent<EnemyScript>());
            //Debug.Log("1");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyList.Remove(collision.gameObject.GetComponent<EnemyScript>());
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {/*
        if (collision.gameObject.tag == "Enemy")
        {
            enemyList.Remove(collision.gameObject.GetComponent<EnemyScript>());
        }*/
    }
}
