using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private Door door;

    public GameObject presPlate;

    private void Awake()
    {
        door = doorGameObject.GetComponent<Door>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == presPlate)
        {
            Debug.Log("OPEN");
            door.OpenDoor();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == presPlate)
        {
            Debug.Log("Close");
            door.CloseDoor();
        }
    }
}
