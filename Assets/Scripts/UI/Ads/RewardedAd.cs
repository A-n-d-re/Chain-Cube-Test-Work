using UnityEngine;
using UnityEngine.UI;
using YG;

public class RewardedAd : MonoBehaviour
{
    [SerializeField] private string advertisementId;

    [SerializeField] private int rewardAmount = 0;

    private void OnEnable()
    {
        YG2.onRewardAdv += Rewarded;
    }

    private void OnDisable()
    {
        YG2.onRewardAdv -= Rewarded;
    }

    private void Rewarded(string id)
    {
        if (id == advertisementId)
        {
            SetReward();
        }
    }

    public void SetReward()
    {
        Debug.Log($"Added: {rewardAmount} coins");
    }

    public void ShowRewardAdv_UseCallback()
    {
        YG2.RewardedAdvShow(advertisementId, () =>
        {
            SetReward();
        });
    }
}