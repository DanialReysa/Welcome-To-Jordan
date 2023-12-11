using System;
using TMPro;
using UnityEngine;

public class ShemaghCount : MonoBehaviour
{
    private static TMPro.TMP_Text text;
    private int count;

    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }


    private void OnEnable() => Shemagh.OnCollected += OnShemaghCollected;
    private void OnDisable() => Shemagh.OnCollected -= OnShemaghCollected;

    private void OnShemaghCollected()
    {
        count++;
        UpdateCount();
    }

    private void UpdateCount()
    {
        text.text = $"{count} / {50}";
    }

    // Public static method to reset the count
    public void ResetCount()
    {
        count = 0;
        UpdateCount();
    }
}
