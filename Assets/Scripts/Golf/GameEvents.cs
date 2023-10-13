using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents 
{
    public static event System.Action onCollisionStone;
    public static event System.Action onClickHit;


    public static void CollisionStonesInvoke(Collision collision)
    {
        onCollisionStone?.Invoke();
    }
    public static void OnClickHitInvoke(Collision collision)
    {
        onClickHit?.Invoke();

    }

}
