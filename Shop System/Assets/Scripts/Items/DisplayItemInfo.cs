using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayItemInfo : MonoBehaviour
{
    public GameObject displayPanel;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemPrice;

    public void ShowDisplay()
    {
        displayPanel.SetActive(true);
    }

    public void HideDisplay()
    {
        displayPanel.SetActive(false);
    }
}
