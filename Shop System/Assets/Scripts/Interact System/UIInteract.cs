using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInteract : MonoBehaviour
{
    [SerializeField] GameObject UIContainer;
    [SerializeField] TextMeshProUGUI interactText;
    [SerializeField] PlayerInteract playerInteract;

    DisplayItemInfo itemInfo;

    private void Awake()
    {
        itemInfo = GameObject.FindWithTag("DisplayInfo").GetComponent<DisplayItemInfo>();
    }

    private void Update()
    {
        if (playerInteract.GetInteractable() != null)
        {
            Show(playerInteract.GetInteractable());
        }
        else
        {
            Hide();
        }
    }

    void Show(IInteractable interactable)
    {
        UIContainer.SetActive(true);
        interactText.text = interactable.GetInteractText();
        itemInfo.ShowDisplay();
        itemInfo.itemName.text = interactable.GetTransform().gameObject.GetComponent<ObjectInteractable>().itemData.Name;
        itemInfo.itemPrice.text = "£ " + interactable.GetTransform().gameObject.GetComponent<ObjectInteractable>().itemData.Price.ToString() + ".00";
    }

    void Hide()
    {
        UIContainer.SetActive(false);
        itemInfo.HideDisplay();
    }
}
