using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public static class PlayerStatus
{
    public static bool PlayerIsLife { get; set; }

    public static Hat PlayerHat { get; set; }

    public static int PlayerBestRewardRank { get; set; }
    public static int PlayerGameRewardRank { get; set; }

    public static bool PlayerIsRun { get; set; }
    public static bool PlayerIsJump { get; set; }
    public static bool PlayerIsDown { get; set; }

    public static void InitPlayerStatus()
    {
        PlayerIsLife = true;
        PlayerGameRewardRank = 0;
        PlayerIsRun = false;
        PlayerIsJump = false;
        PlayerIsDown = false;
        GetSavedStatus();
    }

    public static void GetSavedStatus()
    {

    }
}
