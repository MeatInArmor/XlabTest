using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform stick;
    private bool isDown = false;
    public float range = 30f;
    public float speed = 300f;
    public float power = 10f;

    private void Update()
    {
        isDown = Input.GetMouseButton(0);
        Quaternion rot = stick.localRotation;
        Quaternion toRot = Quaternion.Euler(0,0, isDown ? range : -range);
        stick.localRotation = Quaternion.RotateTowards(rot, toRot, speed* Time.deltaTime);
    }
    public void OnCollisionStick(Collider collider)
    {
        if (collider.TryGetComponent(out Rigidbody stone))
        {
            var dir = isDown ? stick.right : -stick.right;
            stone.AddForce(dir * power * Time.deltaTime);

            if(collider.TryGetComponent(out Stone other))
            {
                other.isAffected = true;
            }
        }
        Debug.Log(collider, this);
    }
}
