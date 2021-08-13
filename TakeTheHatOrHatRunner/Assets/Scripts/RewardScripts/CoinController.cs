using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contabiliza moedas e bonus
/// </summary>
public class CoinController : MonoBehaviour
{
    public int GameCoin { get; set; }

    private void Start()
    {
        GameCoin = 0;
    }

    public void ConvertRewardOnCoin(int reward)
    {
        GameCoin = reward / 10;
    }

    public void DoubleCoins()
    {
        GameCoin *= 2;
    }

    public void TripleCoins()
    {
        GameCoin *= 3;
    }

    
}
