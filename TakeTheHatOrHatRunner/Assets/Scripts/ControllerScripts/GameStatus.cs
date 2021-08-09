using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStatus
{
    public static int Reward { get; set; }
    public static int Coin { get; set; }
    public static bool IsPlay { get; set; }
    public static bool IsPause { get; set; }
    public static bool IsFinishWin { get; set; }
    
    public static void InitiateGameStatus(int reward, int coin, bool isPlay, bool isPause, bool isFinishWin)
    {
        Reward = reward;
        Coin = coin;
        IsPlay = isPlay;
        IsPause = isPause;
        IsFinishWin = isFinishWin;
    }

}
