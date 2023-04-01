using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : HealthyBar
{
    HealthyBar hr;

    void resetHealth()
    {
        //This will set the health to 100, make sure the value you're passing in is not larger than the value of the healthBar, otherwise change it with hr.SetMaxHealth(hp);
        hr.setHealth(100);
    }

    void Start()
    {
        hr = GetComponent<HealthyBar>();
        resetHealth();
    }

    void takeDamage(int damage)
    {
        setHealth(hr.getHealth() - damage);
    }
    
    void heal(int add) // add is the health which is going to be added to the Player's health
    {
        if ((int)hr.getMaxHealth() > ((int)hr.getHealth() + add))
        {
            hr.setHealth(hr.getHealth() + add);
        }
        else
        {
            hr.giveMaxHealth();
        }

    }
}
