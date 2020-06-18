using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessControl : MonoBehaviour
{
    Bloom myBloom;
    
    
    void Start()
    {
        var myVolume = GetComponent<PostProcessVolume>();
        myVolume.profile.TryGetSettings(out myBloom);
    }


    public void SetBloomThreshold(float val)
    {
        myBloom.threshold.value = 1 - val;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
