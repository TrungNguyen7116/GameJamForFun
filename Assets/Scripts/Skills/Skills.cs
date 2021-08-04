using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills
{
    protected int factor;
    protected int countDown;
    protected int countDownMax;

    public Skills()
    {
        factor = 0;
        countDown = 0;
        countDownMax = 0;
    }

    virtual public void Effect()
    { }
    public void Action(GameObject target)
    {
        //target.GetComponent<Character>().TakeDamage(GameManager.instace.characterData.attack * factor);
        Effect();
    }
    public void EndTurn()
    {
        //Endturn
    }
}
