using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinDisplay : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    public void CoinCount(float coins)
    {
        coinText.text = coins.ToString() + ".00";
    }
}
