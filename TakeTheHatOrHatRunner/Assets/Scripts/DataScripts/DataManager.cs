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


    public static void InitializeData()
    {
        Coin = 0;
        TotalCoin = 0;
        SpentCoins = 0;
        BestReward = 0;
        LastReward = 0;
        BestTravelleDistance = 0;
        LastTravelleDistance = 0;
        BestGameTime = 0;
        LastGameTime = 0;
        TotalHats = 0;
        AdsRewardedView = 0;
        AdsInsterstitionView = 0;
        TotalAdsView = 0;
    }

    #endregion Data


    // Constants
    #region Constants

    public const int EXTRA_LIFES_GAME = 1;
    public const int MORE_COINS = 2;
    public const float MAX_SPEED = 30f; // Testar
    public const float INITIAL_SPEED = 3f;
    public const float SPEED_INCREASE_RATE = 3f;

    #endregion Constants
}
