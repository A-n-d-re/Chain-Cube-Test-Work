using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class StickyAd : MonoBehaviour
{
    private void Start()
    {
        if (YG2.GetState("NoAds") == 0)
        {
            YG2.StickyAdActivity(true);
        }
    }
}
