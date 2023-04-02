using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private Door door;

    private void Awake()
    {
        door = doorGameObject.GetComponent<Door>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().tag == "Player" || GetComponent<Collider2D>().tag == "Rock")
        {
            Debug.Log("OPEN");
            door.OpenDoor();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().tag != "Player" || GetComponent<Collider2D>().tag != "Rock" )
        {
            door.CloseDoor();
            Debug.Log("CLOSE");
        }
    }
}
