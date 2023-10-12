using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XLabTest
{
    public class CloudController : MonoBehaviour
    {
        public Transform[] targets;
        public Cloud cloud;
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
            cloud.StopFX();
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
            Vector3 targetPosition = new Vector3(target.position.x, cloud.transform.position.y, target.position.z);
            Vector3 offset = (targetPosition - cloud.transform.position).normalized * moveSpeed * Time.deltaTime;
            cloud.transform.position = Vector3.Lerp(cloud.transform.position, targetPosition, Time.deltaTime * moveSpeed);
            if (Vector3.Distance(cloud.transform.position, targetPosition) < offset.magnitude)
            {
                _moveing = false;
                cloud.PlayFX();
            }
            else
            {
                cloud.transform.Translate(offset);
            }
        }
    }
}