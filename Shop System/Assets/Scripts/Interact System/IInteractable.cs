using UnityEngine;

public interface IInteractable
{
    Transform GetTransform();
    string GetInteractText();
    void Interact(Transform interactorTransform);
}
