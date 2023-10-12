using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XLabTest
{
    public class Cloud : MonoBehaviour
    {
        [SerializeField] private ParticleSystem particleSystem;

        private void Start()
        {
            particleSystem.Stop();
        }

        public void PlayFX ()
        {
            particleSystem.Play();
        }

        public void StopFX()
        {
            particleSystem.Stop();
        }
    }
}
