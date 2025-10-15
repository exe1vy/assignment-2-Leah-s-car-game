using System;
using UnityEngine;

public class gaspedal : MonoBehaviour
{
    public ParticleSystem Particle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Particle.Play();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Particle.Stop();
        }
    }
}
