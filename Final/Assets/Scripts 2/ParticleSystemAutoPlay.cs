using UnityEngine;

public class ParticleSystemAutoPlay : MonoBehaviour
{
    public ParticleSystem particleSystem;

    void Start()
    {
        particleSystem.Play(); // Start the particle system when the scene begins
    }
}
