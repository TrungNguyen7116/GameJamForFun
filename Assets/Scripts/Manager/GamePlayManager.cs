using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    private const int playerTurn = 0;
    private const int enemyTurn = 1;
    private int currentTurn;

    public static GamePlayManager instance;


    public int CurrentTurn { get => currentTurn;}

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        //the first turn is player's turn
        currentTurn = playerTurn;
    }
    void ChangeTurn()
    {
        //Change turn when end turn 
        if (CurrentTurn == playerTurn)
        {
            currentTurn = enemyTurn;
        }
        else
        {
            currentTurn = playerTurn;
        }
    }
    public void Enturn()
    {
        //Endturn
    }
}
