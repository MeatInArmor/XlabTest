using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XLabTest
{
    public class CloudController : MonoBehaviour
    {
        public Transform[] targets;
        public Transform cloud;
        public RainController rainController;
        public float moveSpeed = 3f;
        private int targetIndex = 0;
        public bool _moveing = false;
        private Transform target;

        public void Action()
        {
            Debug.Log("Z", this);
            if(_moveing)
            {
                return;
            }
            _moveing = true;

            targetIndex++;
            if (targetIndex >= targets.Length) 
            {
                targetIndex = 0;
            }
            Debug.Log(targetIndex);

        }
        private void Update()
        {
            if(!_moveing)
            {
                return;
            }
            target = targets[targetIndex];
            Vector3 targetPosition = new Vector3(target.position.x, cloud.position.y, target.position.z);
            cloud.position = Vector3.Lerp(cloud.position, targetPosition, Time.deltaTime * moveSpeed);
            if (Vector3.Distance(cloud.position, targetPosition) < 0.3f)
            {
                _moveing = false;
            }
        }
    }
}