using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public static class GameEvents
    {
        public static event System.Action onCollisionStones;
        public static event System.Action onStickHit;
        public static event System.Action onCollisionObstacles;



        public static void CollisionStonesInvoke(Collision collision)
        {
            onCollisionStones?.Invoke();
        }
        public static void OnStickHitInvoke()
        {
            onStickHit?.Invoke();
        }
        public static void CollisionObstaclesInvoke(Collision collis)
        {
            onCollisionObstacles?.Invoke();
        }
    }
}