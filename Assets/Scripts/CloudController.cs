using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XLabTest
{
    // доделать
    public class CloudController : MonoBehaviour
    {
        public Transform[] targets;
        public Transform cloud;
        public float moveSpeed = 10;
        private int _targetIndex = 0;
        private bool _moveing = false;

        private void Start()
        {

        }
        public void Action()
        {
            Debug.Log("Z", this);
            if(_moveing!)
                return;
            _moveing = true;
            _targetIndex++;
            if (_targetIndex >= targets.Length) 
                _targetIndex = 0;
        }
        private void Update()
        {
            if(_moveing!)
                return;
            Transform target = targets[_targetIndex];
            Vector3 targetPosition = new Vector3(target.position.y, cloud.position.y, target.position.z);
            cloud.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);
            
            if (Vector3.Distance(cloud.position, targetPosition) < 0.1f)
                _moveing = false;
        }
    }
}