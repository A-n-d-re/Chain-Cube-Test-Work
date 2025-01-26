using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class PurchaseReceiver : MonoBehaviour
{
    [SerializeField] private GameObject shop;
    [SerializeField] private GameObject shopButton;

    private void Start()
    {
        if (YG2.GetState("NoAds") == 1)
        {
            shop.SetActive(false);
            shopButton.SetActive(false);
        }
        else
        {
            shopButton.SetActive(true);
        }
    }

    private void OnEnable()
    {
        YG2.onPurchaseSuccess += SuccessPurchased;
    }

    private void OnDisable()
    {
        YG2.onPurchaseSuccess -= SuccessPurchased;
    }

    private void SuccessPurchased(string id)
    {
        switch (id)
        {
            case "noAds":
                YG2.SetState("NoAds", 1);

                shop.SetActive(false);
                shopButton.SetActive(false);

                YG2.StickyAdActivity(false);

                break;
        }
    }
}
