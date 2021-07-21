using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class PlayerStatus
{
    public bool PlayerIsLife { get; set; }

    public Hat PlayerHat { get; set; }

    public int PlayerBestRewardRank { get; set; }
    public int PlayerGameRewardRank { get; set; }

    public bool PlayerIsRun { get; set; }
    public bool PlayerIsJump { get; set; }
    public bool PlayerIsDown { get; set; }

    public void InitPlayerStatus()
    {
        PlayerIsLife = true;
        PlayerGameRewardRank = 0;
        PlayerIsRun = false;
        PlayerIsJump = false;
        PlayerIsDown = false;
        GetSavedStatus();
    }

    public void GetSavedStatus()
    {

    }
}
