using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Stick : MonoBehaviour
{
    //public Transform stick;
    public UnityEvent<Collider> onCollision;
    private void OnCollisionEnter(Collision collision)
    {
        onCollision.Invoke(collision.collider);
    }
    //public void OnCollisionStick(Collider collider)
    //{
    //    stick = this.gameObject.GetComponent<Transform>();
    //    var power = 100f;
    //    bool isDown = this.GetComponentInParent<Player>().isDown;
    //    if (collider.TryGetComponent(out Rigidbody stone))
    //    {
    //        var dir = isDown ? stick.forward : -stick.forward;
    //        stone.AddForce(dir * power, ForceMode.Impulse);

    //        if (collider.TryGetComponent(out Stone other))
    //        {
    //            other.isAffected = true;
    //        }
    //        Debug.Log("dir " + dir + ", power " + power + ", direction" + stick.right);
    //    }
    //    Debug.Log(collider, this);
    //}
}
