using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI pageText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pageText = GetComponent<TextMeshProUGUI>();
    }

   public void UpdatePageText(PlayerInventory playerInventory)
    {
        pageText.text = playerInventory.NumberOfPages.ToString();
    }
}
