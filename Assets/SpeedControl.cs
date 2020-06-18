using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SpeedControl : MonoBehaviour
{
    public float amplitude = 80f;
    public float min = 0.5f;
    // Start is called before the first frame update
    private float curSpeed;
    private float targetSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curSpeed = (targetSpeed - curSpeed) * 0.1f;
        foreach (var videoPlayer in GetComponentsInChildren<VideoPlayer>()) videoPlayer.playbackSpeed = curSpeed * amplitude + min;
    }

    public void SetSpeed(float speed)
    {
        targetSpeed = speed;
    }
}
