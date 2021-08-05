using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : Skills
{
    public Basic()
    {
        factor = 1.0f;
        countDown = 0;
        countDownMax = 1;
    }
    public override void Effect()
    {
        Debug.Log("Basic + " + factor);
    }
}
