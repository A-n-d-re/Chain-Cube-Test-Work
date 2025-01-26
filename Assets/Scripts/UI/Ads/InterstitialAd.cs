using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class InterstitialAd : MonoBehaviour
{
    public void ShowInterstitialAd()
    {
        if (YG2.GetState("NoAds") == 0)
        {
            YG2.InterstitialAdvShow();
        }
    }
}
