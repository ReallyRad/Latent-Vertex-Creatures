using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public float intensity;

    public void SetIntensity(float multiplier)
    {
        GetComponent<Light>().intensity = intensity * multiplier;
    }
}
