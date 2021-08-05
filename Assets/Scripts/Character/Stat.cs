using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    private int currentValue;
    private int maxValue;

    public int CurrentValue 
    { get => currentValue; 
      set { currentValue = value; 
            if (currentValue > maxValue) currentValue = maxValue;
            if (currentValue < 0) currentValue = 0;
          }
    }
    public int MaxValue { get => maxValue; set => maxValue = value; }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Image>().fillAmount = 1.0f * currentValue / maxValue;
    }

    public void InitializeValue(int value)
    {
        currentValue = value;
        maxValue = value;
    }
}
