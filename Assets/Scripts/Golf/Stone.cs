using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Stone : MonoBehaviour
    {
        public bool isAffected = false;
        public bool isAffectedObst = false;
        private ParticleSystem particleSystem;

        private void OnEnable()
        {
            particleSystem = this.GetComponentInChildren<ParticleSystem>();
            particleSystem.Stop();
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.TryGetComponent(out Stone stone))
            {
                if (!stone.isAffected)
                {
                    GameEvents.CollisionStonesInvoke(collision);
                }
            }
            if (collision.transform.TryGetComponent(out Obstacle obst))
            {
                if(!isAffectedObst)
                {
                    GameEvents.CollisionObstaclesInvoke(collision);
                    this.GetComponentInChildren<ParticleSystem>().Play();
                    isAffectedObst = true;
                }
            }
        }
    }
}
