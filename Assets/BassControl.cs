using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassControl : MonoBehaviour
{
    private MeshRenderer[] _planes;
    
    // Start is called before the first frame update
    void Start()
    {
        _planes = transform.GetComponentsInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    public void Bass(float val)
    {
        foreach (var plane in _planes)
        {
            plane.material.SetFloat("Vector1_B71FBE90", val);
        }
    }
}
