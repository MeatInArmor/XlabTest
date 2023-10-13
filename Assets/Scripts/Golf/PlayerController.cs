using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        public XLabTest.Spawner spawner;
        
        private void Update()
        {
            if(Input.GetMouseButtonDown(0)) 
            {
                Debug.Log("qwe");
            }
        }
    }
}
