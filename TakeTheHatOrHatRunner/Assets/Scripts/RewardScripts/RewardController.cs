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
        txtBestReward.text = BestRewardSave.ToString();
    }

    private void Update()
    {
        txtGameReward.text = GameReward.ToString();
    }

    public void AddRewards()
    {
        GameReward += DataManager.REWARD_1;
    }

}
