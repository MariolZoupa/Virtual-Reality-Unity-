using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateGameState(GameState.SpawnPlayer);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.SpawnPlayer:
                break;
            case GameState.Victory:
                break;
            case GameState.Lose:
                break;


        }

        OnGameStateChanged?.Invoke(newState);

    }

}

public enum GameState
{ 
    SpawnPlayer, Victory, Lose
}
