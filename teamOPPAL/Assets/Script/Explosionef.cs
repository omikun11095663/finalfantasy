﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosionef : MonoBehaviour
{
    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        particle.Play();
    }
}
