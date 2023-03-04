using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInteract : MonoBehaviour
{
    [SerializeField] GameObject UIContainer;
    [SerializeField] TextMeshProUGUI interactText;
    [SerializeField] PlayerInteract playerInteract;

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
    }

    void Hide()
    {
        UIContainer.SetActive(false);
    }
}
