using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XLabTest
{
    public class PlayerController : MonoBehaviour
    {
        public Spawner spawner;
        public CloudController cloudController;
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("x");
                spawner.Spawn();
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                cloudController.Action();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("sp");
            }
        }
    }
}
