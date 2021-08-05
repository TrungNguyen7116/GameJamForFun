using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillButton : MonoBehaviour
{
    private Skills mySkill;

    public void SetSkill(Skills skill)
    {
        mySkill = skill;
    }

    public void Action()
    {
        mySkill.Action(null);
        //End turn of player
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Player>().Endturn();
        //Hide skills panel when end turn of player
        GameObject skillsPanel = GameObject.Find("Skills Panel");
        skillsPanel.GetComponent<CanvasGroup>().alpha = 0;
        skillsPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
