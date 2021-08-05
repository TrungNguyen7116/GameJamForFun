using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : Skills
{
    public Fire()
    {
        factor = 1.5f;
        countDown = 0;
        countDownMax = 3;
    }
    public override void Effect()
    {
        Debug.Log("Fire + " + factor);
    }
}
