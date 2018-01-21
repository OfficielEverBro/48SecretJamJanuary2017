using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

    new public string name = "New Item";
    public Sprite icon = null;
    public bool isConsumable = false;
    public bool isConsumed = false;

    public float healPower;

    public void Eat()
    {
        if(!isConsumable || isConsumed)
        {
            return;
        }

        LifeBarManager.instance.Increase(healPower);
        isConsumed = true;
    }
}
