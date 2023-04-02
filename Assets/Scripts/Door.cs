using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;

    public void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void OpenDoor()
    {
        anim.SetBool("Open", true);
    }

    public void CloseDoor()
    {
        anim.SetBool("Open", false);
    }
}
