using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace XLabTest
{
    public class Spawner : MonoBehaviour
    {
        public GameObject[] prefabs;
        public void Spawn()
        {
            Debug.Log("spawning...");
            var prefab = GetRandomPrefab();
            if (prefab == null)
            {
                Debug.Log("no spawner");
                return;
            }
            Instantiate(prefab, transform.position, Quaternion.identity);
        } 
        private GameObject GetRandomPrefab()
        {
            if (prefabs.Length == null)
            {
                Debug.Log("no spawner");
                return null;
            }
            int index = Random.Range(0, prefabs.Length);
            return prefabs[index];
        }
    }
}
