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

    void Damaged(int damage)
    {
        setHealth(getHealth() - damage);
    }
    
}
