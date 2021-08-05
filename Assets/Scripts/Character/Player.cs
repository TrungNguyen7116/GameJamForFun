using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private CanvasGroup skillsPanel;
    private CanvasGroup itemsPanel;

    private bool isUsing; //isUsing = true when player is using something (such skill or item); when isUsing = true, player can't move
    void Start()
    {
        skillsPanel = GameObject.Find("Skills Panel").GetComponent<CanvasGroup>();
        itemsPanel = GameObject.Find("Items Panel").GetComponent<CanvasGroup>();
        myTurn = 0; //turn of player is 0
    }
    public override void Action()
    {
        if (!isUsing) Move();
        Use();
    }
    public override void Move()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-1, 0, 0);
            Endturn();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(1, 0, 0);
            Endturn();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
            Endturn();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, -1, 0);
            Endturn();
        }
    }
    void Use()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            itemsPanel.alpha = 0;
            itemsPanel.blocksRaycasts = false;
            if (skillsPanel.alpha == 0)
            {
                isUsing = true;
                skillsPanel.alpha = 1;
                skillsPanel.blocksRaycasts = true;
            }
            else
            {
                isUsing = false;
                skillsPanel.alpha = 0;
                skillsPanel.blocksRaycasts = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            skillsPanel.alpha = 0;
            skillsPanel.blocksRaycasts = false;
            if (itemsPanel.alpha == 0)
            {
                isUsing = true;
                itemsPanel.alpha = 1;
                itemsPanel.blocksRaycasts = true;
            }
            else
            {
                isUsing = false;
                itemsPanel.alpha = 0;
                itemsPanel.blocksRaycasts = false;
            }
        }
    }
    public override void Endturn()
    {
        base.Endturn();
        isUsing = false;
    }
}
