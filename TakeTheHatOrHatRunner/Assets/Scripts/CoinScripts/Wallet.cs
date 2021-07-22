using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Wallet
{
    public static int Coin { get; set; }

    public static void ReceiveCoin(int coinPlus)
    {
        Coin += coinPlus;
    }

    public static void RemoveCoin(int coinMinus)
    {
        Coin -= coinMinus;
    }


}
