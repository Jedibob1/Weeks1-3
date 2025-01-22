using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public AnimationCurve Jump;
    [Range(0,1)]
    public float t;
    public Transform maxHieght;
    public Transform ground;
    
    public Boolean touchingGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
