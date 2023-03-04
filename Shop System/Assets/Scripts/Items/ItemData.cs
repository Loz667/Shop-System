using UnityEngine;

[CreateAssetMenu(menuName = "Item", fileName = "New Item Data", order = 51)]
public class ItemData : ScriptableObject
{
    [SerializeField] string itemName;
    [SerializeField] float itemPrice;

    public string Name { get { return itemName; } }
    public float Price { get { return itemPrice; } }
}
