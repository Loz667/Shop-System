using UnityEngine;

public class ObjectInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] ItemData itemData;

    public string GetInteractText()
    {
        return "Buy " + itemData.Name;
    }

    public Transform GetTransform()
    {
        return transform;
    }

    public void Interact(Transform interactorTransform)
    {
        BuyItem();
    }

    void BuyItem()
    {
        Destroy(gameObject);
        Debug.Log("Item Purchased");
    }
}
