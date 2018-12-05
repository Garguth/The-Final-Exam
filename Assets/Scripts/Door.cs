using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    float duration = 3.0f;
    float originalRange;
    Light lt;
	// Use this for initialization
	void Start () {
        lt = GetComponent<Light>();
        originalRange = lt.range;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, 10.0f * Time.deltaTime);
        transform.Rotate(Vector3.right, 10.0f * Time.deltaTime);
        var amplitude = Mathf.PingPong(Time.time, duration);
        amplitude = amplitude / duration * 0.5f + 0.5f;
        lt.range = originalRange * amplitude;

	}
}
