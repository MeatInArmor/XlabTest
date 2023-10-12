using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public bool isAffected = false;
    public static System.Action onCollisionStone;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.TryGetComponent(out Stone other))
        {
            if(other.isAffected)
            {
                onCollisionStone?.Invoke();
            }

        }
    }
}
