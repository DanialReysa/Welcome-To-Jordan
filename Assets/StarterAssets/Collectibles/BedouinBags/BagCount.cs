using System;
using TMPro;
using UnityEngine;

public class BagCount : MonoBehaviour
{
    private static TMPro.TMP_Text text;
    private int count;

    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }


    private void OnEnable() => Bag.OnCollected += OnBagCollected;
    private void OnDisable() => Bag.OnCollected -= OnBagCollected;

    private void OnBagCollected()
    {
        count++;
        UpdateCount();
    }

    private void UpdateCount()
    {
        text.text = $"{count} / {60} BAG";
    }

    // Public static method to reset the count
    public void ResetCount()
    {
        count = 0;
        UpdateCount();
    }
}
