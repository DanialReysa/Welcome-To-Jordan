using System;
using UnityEngine;

public class ResetCounter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Reset the count to 0
            BagCount bagCount = FindObjectOfType<BagCount>();
            DallahCount dallahCount = FindObjectOfType<DallahCount>();
            ShemaghCount shemaghCount = FindObjectOfType<ShemaghCount>();

            if (bagCount != null)
            {
                bagCount.ResetCount();
            }

            if (dallahCount != null)
            {
                dallahCount.ResetCount();
            }

            if (shemaghCount != null)
            {
                shemaghCount.ResetCount();
            }

            // Optionally, you can perform other actions here if needed.

            // Destroy this game object after collision
            Destroy(gameObject);
        }
    }
}
