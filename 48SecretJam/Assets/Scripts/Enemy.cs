using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "PNJ/Enemy")]
public class Enemy : ScriptableObject
{

    new public string name = "New Enemy";
    public GameObject prefab = null;
    public int damage = 0;
    public int life = 0;
    public GameObject[] drops;

}


