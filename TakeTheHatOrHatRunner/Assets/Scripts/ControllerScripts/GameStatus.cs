using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus
{
    public int Reward { get; set; }
    public int Coin { get; set; }
    public bool IsPlay { get; set; }
    public bool IsPause { get; set; }
    public bool IsFinishWin { get; set; }

    public GameStatus() { }
    
    public GameStatus(int reward, int coin, bool isPlay, bool isPause, bool isFinishWin)
    {
        this.Reward = reward;
        this.Coin = coin;
        this.IsPlay = isPlay;
        this.IsPause = isPause;
        this.IsFinishWin = isFinishWin;
    }

}
