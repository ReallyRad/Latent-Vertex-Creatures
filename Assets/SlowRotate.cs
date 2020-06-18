using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowRotate : MonoBehaviour
{
    public float amplitude = 20;
    public float speed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Transform trans in transform)
        trans.rotation = Quaternion.Euler(Mathf.Sin(Time.time*speed) * amplitude, Mathf.Sin(Time.time*speed + (float) Math.PI/2) * amplitude, 0);
    }
}
