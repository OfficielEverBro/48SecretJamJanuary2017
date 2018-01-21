using UnityEngine;
using UnityEngine.UI;

public class ActionButtonScript : MonoBehaviour {

    public GameObject backGround;
    public GameObject objectImage;
    public Sprite Slot_Empty;
    public Sprite Slot_Full;
    public Item item;

    private void Start()
    {
        if (item == null)
            EmptyButton();
        else
            FillButton(item);
    }

    public void FillButton(Item item)
    {
        backGround.GetComponent<Image>().sprite = Slot_Full;
        objectImage.GetComponent<Image>().sprite = item.icon;
        objectImage.GetComponent<Image>().enabled = true;
        this.item = item;
        Debug.Log("Picked " + item.name);
    }

    public void EmptyButton()
    {
        if (item != null && item.name == "Meat")
        {
            LifeBarManager.instance.Increase(20);
            Debug.Log(item.name);
        }

        backGround.GetComponent<Image>().sprite = Slot_Empty;
        objectImage.GetComponent<Image>().enabled = false;
        objectImage.GetComponent<Image>().sprite = null;
        item = null;

    }
}
