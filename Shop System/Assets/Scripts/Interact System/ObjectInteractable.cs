using UnityEngine;

public class ObjectInteractable : MonoBehaviour, IInteractable
{
    public ItemData itemData;

    PlayerCoinCount playerCoins;

    private void Awake()
    {
        playerCoins = GameObject.FindWithTag("Player").GetComponent<PlayerCoinCount>();
    }

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
        playerCoins.currentCoinCount -= itemData.Price;
        playerCoins.UpdateCoinDisplay();
        Destroy(gameObject);
        Debug.Log("Item Purchased");
    }
}
