using UnityEngine;

public class ActionBarScript : MonoBehaviour {

    public GameObject[] abs = new GameObject[5];

    public int FindFirstBarEmpty()
    {
        for(int i =0; i < abs.Length; i++)
        {
            if( abs[i].GetComponent<ActionButtonScript>().item == null)
            {
                return i;
            }
        }
        return -1;
    }

    public void placeItemInInventory(Item item)
    {
        int placeNum = FindFirstBarEmpty();
        if (placeNum != -1)
        {
            abs[placeNum].GetComponent<ActionButtonScript>().FillButton(item);
        }
    }
}
