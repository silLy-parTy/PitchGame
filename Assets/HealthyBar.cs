using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthyBar : MonoBehaviour
{
    public Slider slider;

    public void setMaxHealth(int health) // this sets the maximum health and sets the player's health to that level
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void giveMaxHealth() // this sets the health to the player's maximum health
    {
        slider.value = slider.maxValue;
    }

    public void setHealth(int health) // this sets the health of the player to the specified amount
    {
        if (slider.maxValue >= slider.value)
        {
            slider.value = health;
        }
        else
        {
            giveMaxHealth();
        }
    }

    public int getHealth() // this returns the health of the player
    {
        return (int)slider.value;
    }

    public int getMaxHealth() // this returns the maximum health of the player
    {
        return (int)slider.maxValue;
    }
}
