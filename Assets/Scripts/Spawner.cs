using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace XLabTest
{
        // доделать

    public class Spawner : MonoBehaviour
    {
        public GameObject[] prefabs;
        public void Spawn()
        {
            Debug.Log("spawning...");
            if (prefabs.Length == null)
            {
                Debug.Log("no spawner");
                return;
            }
            var index = prefabs[Random.Range(0, prefabs.Length)];
            if (index == null)
            {
                Debug.Log("no spawner");
                return;
            }
            Instantiate(index, transform.position, Quaternion.identity);
        } 
        //private GameObject GetGameObject()
        //{

        //}
    }
}
