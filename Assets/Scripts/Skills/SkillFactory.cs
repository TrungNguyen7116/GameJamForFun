using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory : MonoBehaviour
{
    public SkillFactory()
    { }
    public static Skills GetSkill(EnumSkill type)
    {
        //switch-case
        return new Skills();
    }
}
