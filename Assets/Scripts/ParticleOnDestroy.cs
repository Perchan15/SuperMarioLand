using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleOnDestroy : MonoBehaviour
{
    public ParticleSystem poofParticles;

    public void SpawnParticle(Vector3 position)
    {
        Instantiate(poofParticles, position, Quaternion.identity);
    }
}
