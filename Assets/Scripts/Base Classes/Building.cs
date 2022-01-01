using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    // values
    
    protected int money;
    protected int health;
    private float timeValue;
    private float timeToWork;

    //fu
    private void Timer()
    {
        timeValue += Time.deltaTime;
    }

    private void MakeMony()
    {
        if (timeValue >= timeToWork)
        {
            timeValue /= timeToWork;
            health = money += 10;
            
        }
    }

    private void Death()
    {
        if(health <= 0)
            gameObject.SetActive(false);
    }

    protected virtual void Work()
    {
        Timer();
        MakeMony();
        Death();
    }

    protected  void GetValue(int healthMoney, int timeToWork)
    {
        this.money = this.health = healthMoney;
        this.timeToWork = timeToWork;
    }
    


}
