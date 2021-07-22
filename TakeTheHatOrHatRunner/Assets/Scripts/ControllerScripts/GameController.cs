using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameStatus gameStatus;

    void Start()
    {
        gameStatus = new GameStatus();
    }

    // GamePlay Functions

    public void PlayGame()
    {

    }

    public void PauseGame(bool pause)
    {
        pause = !pause;
        gameStatus.IsPause = pause;
        if (pause) Time.timeScale = 0;
        else Time.timeScale = 1;
    }
}
