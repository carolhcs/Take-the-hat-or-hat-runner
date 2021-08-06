using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dados de jogo importantes para serem salvos
/// Variaveis Constantes
/// </summary>
public static class DataManager
{
    // Data
    #region Data
    // Coin
    public static int Coin { get; set; }
    public static int TotalCoin { get; set; }
    public static int SpentCoins { get; set; }

    // Reward
    public static int BestReward { get; set; }
    public static int LastReward { get; set; }

    // Distance
    public static int BestTravelleDistance { get; set; }
    public static int LastTravelleDistance { get; set; }

    // Time
    public static int BestGameTime { get; set; }
    public static int LastGameTime { get; set; }

    // Hats
    public static int TotalHats { get; set; }
    public static string[] HatInBagNames { get; set; } // Array
    public static int[] HatInBagIds { get; set; }

    // Monetization
    public static int AdsRewardedView { get; set; }
    public static int AdsInsterstitionView { get; set; }
    public static int TotalAdsView { get; set; }

    #endregion Data


    // Constants
    #region Constants


    #endregion Constants
}
