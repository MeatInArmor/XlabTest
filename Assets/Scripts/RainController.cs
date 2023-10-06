using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace XLabTest
{
    public class RainController : MonoBehaviour
    {
        public CloudController cloudController;
        public Transform cloud;
        public GameObject raindrop;
        private void Update()
        {
            if(!cloudController._moveing)
            {
                Debug.Log("1");
                float X = Random.Range(-4f, 4f);
                float Z = Random.Range(-4f, 4f); 
                Vector3 rainDropSpawnPoint = new Vector3(cloud.position.x + X, cloud.position.y, cloud.position.z - Z);
                Instantiate(raindrop, rainDropSpawnPoint, Quaternion.identity);
            }
        }
    }
}