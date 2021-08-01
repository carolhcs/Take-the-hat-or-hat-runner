using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Data

    // Coin
    public int Coin { get; set; }
    public int TotalCoin { get; set; }
    public int SpentCoins { get; set; }

    // Reward
    public int BestReward { get; set; }
    public int LastReward { get; set; }

    // Distance
    public int BestTravelleDistance { get; set; }
    public int LastTravelleDistance { get; set; }

    // Time
    public int BestGameTime { get; set; }
    public int LastGameTime { get; set; }

    // Hats
    public int TotalHats { get; set; }
    public string[] HatInBagNames { get; set; }
    public int[] HatInBagIds { get; set; }

    // Monetization


}
