using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private Door door;
    public GameObject RTC;
    

    public Animator anim;
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
            anim.SetBool("Pressed", true);
            RTC.GetComponent<RoomTorchControl>().RoomTourchOn();
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.lever);
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.lit);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == presPlate)
        {
            Debug.Log("Close");
            door.CloseDoor();
            anim.SetBool("Pressed", false);
            RTC.GetComponent<RoomTorchControl>().RoomTourchOff();
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.lit);
        }
    }
}
