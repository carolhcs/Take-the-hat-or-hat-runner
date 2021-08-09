using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controllers on buttons click
/// </summary>
public class PlayerController : MonoBehaviour
{
    public GameObject playerBody;
    private GameController gameController;
    private PlayerBehavior playerBehavior;
    

    void Start()
    {
        GetPlayerComponents();
    }

    public void PauseGame()
    {
        gameController.PauseGame(GameStatus.IsPause);

    }

    public void PlayerJump()
    {
        playerBehavior.JumpBehavior();
    }

    public void PlayerDown()
    {
        playerBehavior.DownBehavior();
    }

    private void GetPlayerComponents()
    {
        playerBehavior = playerBody.GetComponent<PlayerBehavior>();
        gameController = FindObjectOfType<GameController>();
    }



}
