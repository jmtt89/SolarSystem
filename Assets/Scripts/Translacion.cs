using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translacion : MonoBehaviour {
    int factor = 12;
    public long timeAround = 31536000;
    public Transform origin;

	// Use this for initialization
	void Start () {	
	}

    // Update is called once per frame
    void Update() {
        transform.RotateAround(origin.position, Vector3.down, 360.0f / (timeAround/factor) * Time.deltaTime);
	}
}
