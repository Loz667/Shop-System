using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoinCount : MonoBehaviour
{
    CoinDisplay coinDisplay;

    public float currentCoinCount;

    private void Start()
    {
        coinDisplay = GameObject.Find("Canvas").GetComponentInChildren<CoinDisplay>();
        UpdateCoinDisplay();
    }

    public void UpdateCoinDisplay()
    {
        coinDisplay.CoinCount(currentCoinCount);
    }
}
