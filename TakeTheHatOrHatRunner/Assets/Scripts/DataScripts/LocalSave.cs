using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Salvar, Carregar e Apagar dados localmente no dispositivo do usuário
/// Apagar não estará disponivel para o jogador
/// </summary>
public class LocalSave : MonoBehaviour
{

    public void SaveGameData ()
    {
        // Coin
        PlayerPrefs.SetInt("Coin", DataManager.Coin);
        PlayerPrefs.SetInt("TotalCoin", DataManager.TotalCoin);
        PlayerPrefs.SetInt("SpentCoins", DataManager.SpentCoins);
        // Reward
        PlayerPrefs.SetInt("BestReward", DataManager.BestReward);
        PlayerPrefs.SetInt("LastReward", DataManager.LastReward);
        // Distance
        PlayerPrefs.SetInt("BestTravelleDistance", DataManager.BestTravelleDistance);
        PlayerPrefs.SetInt("LastTravelleDistance", DataManager.LastTravelleDistance);
        // Time
        PlayerPrefs.SetInt("BestGameTime", DataManager.BestGameTime);
        PlayerPrefs.SetInt("LastGameTime", DataManager.LastGameTime);
        // Hats
        PlayerPrefs.SetInt("TotalHats", DataManager.TotalHats);
        SetStringArray("HatInBagNames", DataManager.HatInBagNames);
        SetIntArray("HatInBagIds", DataManager.HatInBagIds);
        //PlayerPrefsX.SetStringArray("HatInBagNames", DataManager.HatInBagNames);
        //PlayerPrefsX.SetIntArray("HatInBagIds", DataManager.HatInBagIds);
        // Monetization
        PlayerPrefs.SetInt("AdsRewardedView", DataManager.AdsRewardedView);
        PlayerPrefs.SetInt("AdsInsterstitionView", DataManager.AdsInsterstitionView);
        PlayerPrefs.SetInt("TotalAdsView", DataManager.TotalAdsView);

        PlayerPrefs.Save();
    }

    public void LoadGameData()
    {
        // Todos os dados sempre serão salvos juntos, então só preciso verificar algumas keys
        if (PlayerPrefs.HasKey("Coin") && PlayerPrefs.HasKey("BestReward") && PlayerPrefs.HasKey("AdsRewardedView"))
        {
            DataManager.Coin = PlayerPrefs.GetInt("Coin");
            DataManager.TotalCoin = PlayerPrefs.GetInt("TotalCoin");
            DataManager.SpentCoins = PlayerPrefs.GetInt("SpentCoins");
            DataManager.BestReward = PlayerPrefs.GetInt("BestReward");
            DataManager.LastReward = PlayerPrefs.GetInt("LastReward");
            DataManager.BestTravelleDistance = PlayerPrefs.GetInt("BestTravelleDistance");
            DataManager.LastTravelleDistance = PlayerPrefs.GetInt("LastTravelleDistance");
            DataManager.BestGameTime = PlayerPrefs.GetInt("BestGameTime");
            DataManager.LastGameTime = PlayerPrefs.GetInt("LastGameTime");
            DataManager.TotalHats = PlayerPrefs.GetInt("TotalHats");
            DataManager.HatInBagNames = GetStringArray("HatInBagNames");
            DataManager.HatInBagIds = GetIntArray("HatInBagIds");
            DataManager.AdsRewardedView = PlayerPrefs.GetInt("AdsRewardedView");
            DataManager.AdsInsterstitionView = PlayerPrefs.GetInt("AdsInsterstitionView");
            DataManager.TotalAdsView = PlayerPrefs.GetInt("TotalAdsView");
        }
    }

    public void SetStringArray(string nameId, List<string> stringArray)//string[] stringArray
    {
        if (stringArray != null)
        {
            for (int i = 0; i < stringArray.Count; i++)
            {
                nameId = nameId + i;
                PlayerPrefs.SetString(nameId, stringArray[i]);
            }
        }
    }

    public void SetIntArray(string nameId, List<int> intArray)//int[] intArray
    {
        if (intArray != null) {
            for (int i = 0; i < intArray.Count; i++)
            {
                nameId = nameId + i;
                PlayerPrefs.SetInt(nameId, intArray[i]);
            }
        }
    }

    public List<string> GetStringArray(string nameId)
    {
        List<string> stringArray = new List<string>();
        int i = 0;
        while (PlayerPrefs.HasKey(nameId + i))
        {
            stringArray.Add(PlayerPrefs.GetString(nameId + i));
            i++;
        }
        /*stringArray = new string[i];
        for(int j = 0; j < i; j++)
        {
            stringArray[j] = PlayerPrefs.GetString(nameId + j);
        }*/
        return stringArray;
    }

    public List<int> GetIntArray(string nameId)
    {
        List<int> intArray = new List<int>();
        int i = 0;
        while (PlayerPrefs.HasKey(nameId + i))
        {
            intArray.Add(PlayerPrefs.GetInt(nameId + i));
            i++;
        }
        /*intArray = new int[i];
        for (int j = 0; j < i; j++)
        {
            intArray[j] = PlayerPrefs.GetInt(nameId + j);
        }*/
        return intArray;
    }


    public void DeleteGameData(string key)
    {
        PlayerPrefs.DeleteKey(key);
    }

    public void DeleteAllGameData()
    {
        PlayerPrefs.DeleteAll();
    }
}
