using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPanelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject skillButton;
    // Start is called before the first frame update
    void Start()
    {
        InitializePanel();
    }

    void InitializePanel()
    {
        if (GameManager.instace != null)
        {
            for (int i = 0; i < GameManager.instace.skillData; i++)
            {
                GameObject button = Instantiate(skillButton, transform);
                Skills newSkill = SkillFactory.GetSkill((EnumSkill)i);
                button.GetComponent<SkillButton>().SetSkill(newSkill);
            }
        }
    }
}
