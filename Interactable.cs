using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// template for subclasses ie buttons doors healthpack etc
public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
public void BaseInteract()
{
    Interact();
}

    protected virtual void Interact()
{

}
}
