using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionPointRadius =0.5f;
    [SerializeField] private LayerMask interactableMask;
    public GameObject detectedObject;

    private void Update()
    {
        if(DetectedObject())
        {
            if (InteractInput())
            {
                detectedObject.GetComponent<Item>().Interact();
                Debug.Log("INTERACT");
            }
        }
    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectedObject()
    {
        Collider2D obj = Physics2D.OverlapCircle(interactionPoint.position, interactionPointRadius, interactableMask);
        if (obj == null)
        {
            detectedObject = null;
            return false;
        }
        else
        {
            detectedObject = obj.gameObject;
            return true;
        }
    }
}
