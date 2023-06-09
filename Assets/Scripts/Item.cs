using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Item : MonoBehaviour
{
    public enum interactionType { NONE, lightTourch, brasier }
    public interactionType type;

    public GameObject light;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    //private bool on = false;

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
                light.SetActive(true);
                SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.lit);
                
                break;
            case interactionType.brasier:
                spriteRenderer.sprite = newSprite;
                light.SetActive(true);
                break;
            default:
                Debug.Log("NULL interact");
                break;
        }
    }
    public void lightOn()
    {
        light.SetActive(true);
    }

    public void lightOff()
    {
        light.SetActive(false);
    }

}
