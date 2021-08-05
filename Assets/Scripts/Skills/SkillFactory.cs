using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory : MonoBehaviour
{
    public SkillFactory()
    { }
    public static Skills GetSkill(EnumSkill type)
    {
        switch (type)
        {
            case EnumSkill.BASIC:
                return new Basic();
            case EnumSkill.FIRE:
                return new Fire();
            case EnumSkill.WATER:
                return new Water();
        }
        return new Skills();
    }
}
