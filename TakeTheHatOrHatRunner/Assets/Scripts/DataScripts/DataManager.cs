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
    public static List<string> HatInBagNames = new List<string>();// Array
    public static List<int> HatInBagIds = new List<int>();
    //public static string[] HatInBagNames { get; set; } // Array
    //public static int[] HatInBagIds { get; set; }

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
        HatInBagNames.Add("Default");
        HatInBagIds.Add(0);
    }

    #endregion Data


    // Constants
    #region Constants

    public const int EXTRA_LIFES_GAME = 1;
    public const int MORE_COINS = 2;
    public const float MAX_SPEED = 10f; // Testar
    public const float INITIAL_SPEED = 1.5f; // Min 1 Max 10
    public const float TIMER = 60f; 
    public const float TIMER_REWARD = 5f; // A cada TIMER_REWARD (tempo) recebe REWARD_1
    public const int BONUS_REWARD_2 = 12; // A cada BONUS_REWARD_2 (vezes) recebe REWARD_2
    public const float SPEED_TIMER_1 = 5f; // Tempo para subir a primeira velocidade
    public const float SPEED_TIMER_2 = 10f; // Tempo para subir a segunda velocidade
    public const float SPEED_TIMER_3 = 15f; // Tempo para subir a terceira velocidade
    public const int UP_SPEED_TIMER_1 = 12; // Vezes para subir o speedtimer 1
    public const int UP_SPEED_TIMER_2 = 6; // Vezes para subir o speedtimer 2
    public const float SPEED_INCREASE_1 = 0.3f; // Primeira Velocidade
    public const float SPEED_INCREASE_2 = 0.25f; // Segunda Velocidade
    public const float SPEED_INCREASE_3 = 0.2f; // Terceira Velocidade
    public const int REWARD_1 = 10; // Reward
    public const int REWARD_2 = 1000; // Double Reward
    public const int REWARD_3 = 5000; // Extra Reward

    #endregion Constants
}
