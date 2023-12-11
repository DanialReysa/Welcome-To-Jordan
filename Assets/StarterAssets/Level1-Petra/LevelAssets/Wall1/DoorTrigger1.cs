using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject Wall;

    bool isOpened = false;

    void OnTriggerEnter(Collider Player)
    {
        if (!isOpened)
        {
            isOpened = true;
            Wall.transform.position += new Vector3(0, 10, 0);
        }
    }
}