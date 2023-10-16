using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Stone : MonoBehaviour
    {
        public bool isAffected = false;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.TryGetComponent(out Stone other))
            {
                if (!other.isAffected)
                {
                    GameEvents.CollisionStonesInvoke(collision);
                }

            }
        }
    }
}
