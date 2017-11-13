using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour {
    int factor = 12;
    public long timeAround = 86400;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down, 360.0f / (timeAround/factor) * Time.deltaTime, Space.World);
    }
}
