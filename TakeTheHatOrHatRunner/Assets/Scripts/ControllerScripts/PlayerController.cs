using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controllers on buttons click
/// </summary>
public class PlayerController : MonoBehaviour
{
    public GameObject playerBody;

    private PlayerBehavior playerBehavior;
    

    void Start()
    {
        GetPlayerComponents();
    }

    public void PauseGame(bool isPaused)
    {
        isPaused = !isPaused;
        if(isPaused) Time.timeScale = 0;
        else Time.timeScale = 1;
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
    }



}
