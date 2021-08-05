using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Skills
{
    public Water()
    {
        factor = 1.1f;
        countDown = 0;
        countDownMax = 3;
    }
    public override void Effect()
    {
        Debug.Log("Water + " + factor);
    }
}
