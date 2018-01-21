using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour {

    public Item item;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerTag")
        {
            //Check for inventory space
            if (GameObject.Find("ActionBar").GetComponent<ActionBarScript>().FindFirstBarEmpty() != -1)
            {
                GameObject.Find("ActionBar").GetComponent<ActionBarScript>().placeItemInInventory(gameObject.GetComponent<ItemHolder>().item);
                Destroy(gameObject);
            }
        }
    }
}
