using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Animator playerAnimaror;
        public Transform stick;
        public Transform helper;
        private bool isDown = false;
        //public float range = 50f;
        //public float speed = 300f;
        public float power;
        private Vector3 lastPosition;

        private void Start()
        {
            power = 50f;
        }
        private void Update()
        {
            //isDown = Input.GetMouseButton(0);
            lastPosition = helper.position;
            playerAnimaror.SetBool("KeyDown", isDown);
            //Quaternion rot = stick.localRotation;
            //Quaternion toRot = Quaternion.Euler(isDown ? range : -range, 0, 0);
            //stick.localRotation = Quaternion.RotateTowards(rot, toRot, speed * Time.deltaTime);
            //Debug.Log(isDown);
        }

        public void SetDown(bool value)
        {
            isDown = value;
        }

        public void OnCollisionStick(Collider collider)
        {
            if (collider.TryGetComponent(out Rigidbody stone))
            {
                //var dir = isDown ? stick.forward : -stick.forward;
                var dir = (helper.position - lastPosition).normalized;

                stone.AddForce(dir * power, ForceMode.Impulse);

                if (collider.TryGetComponent(out Stone other) && !other.isAffected)
                {
                    other.isAffected = true;
                    //GameEvents.OnClickHitInvoke(this);
                    GameEvents.OnStickHitInvoke();
                }
            }
        }
    }
}


