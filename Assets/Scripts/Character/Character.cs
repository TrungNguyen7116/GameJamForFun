using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    protected Stat HP;
    protected int attack;
    protected int defense;
    protected float critical;
    protected float lifesteal;

    protected int myTurn;

    // Update is called once per frame
    void Update()
    {
        if (myTurn == GamePlayManager.instance.CurrentTurn)
        {
            Action();
        }
    }
    public virtual void Action()
    { }
    public virtual void Move()
    { }
    public virtual void Endturn()
    {
        GamePlayManager.instance.Enturn();
    }
}
