using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Item : MonoBehaviour
{
    public enum interactionType { NONE, lightTourch }
    public interactionType type;

    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 7;
    }

    public void Interact()
    {
        switch(type)
        {
            case interactionType.lightTourch:
                Debug.Log("light");
                break;
            default:
                Debug.Log("NULL interact");
                break;
        }
    }
}
