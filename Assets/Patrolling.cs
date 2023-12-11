using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public Transform[] points;
    int current;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        current = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(270f, Time.time * 100f, 270);

        if (transform.position != points[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
        }
        else
            current = (current + 1) % points.Length;
    }
}
