using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardController : MonoBehaviour
{
    public Text txtBestReward;
    public Text txtGameReward;
    public int GameReward { get; set; }
    public int BestRewardSave { get; set; }

    private void Start()
    {
        GameReward = 0;
        txtBestReward.text = BestRewardSave.ToString("00000");
    }

    private void Update()
    {
        txtGameReward.text = GameReward.ToString("0000000");
    }

    public void AddRewards()
    {
        GameReward += DataManager.REWARD_1;
    }

}
