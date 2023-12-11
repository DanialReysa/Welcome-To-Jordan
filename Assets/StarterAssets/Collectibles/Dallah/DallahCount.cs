using System;
using TMPro;
using UnityEngine;

public class DallahCount : MonoBehaviour
{
    private static TMPro.TMP_Text text;
    private int count;

    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }


    private void OnEnable() => Dallah.OnCollected += OnDallahCollected;
    private void OnDisable() => Dallah.OnCollected -= OnDallahCollected;

    private void OnDallahCollected()
    {
        count++;
        UpdateCount();
    }

    private void UpdateCount()
    {
        text.text = $"{count} / {58}";
    }

    // Public static method to reset the count
    public void ResetCount()
    {
        count = 0;
        UpdateCount();
    }
}
