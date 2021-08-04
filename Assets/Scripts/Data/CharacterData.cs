using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    public string name;
    public int HP;
    public int attack;
    public int defense;
    public float critical;
    public float lifesteal;

    // Default constructor when initially creating character
    // Test data
    public CharacterData() 
    {
        HP = 100;
        attack = 10;
        defense = 3;
        critical = 0f;
        lifesteal = 0f;
    }
}
