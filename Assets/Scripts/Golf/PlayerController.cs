using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Player player;

        private void Start()
        {
            if(player == null) 
            {
                Debug.Log("bruh");            
            }
        }
        private void Update()
        {
            if (player == null)
            player.SetDown(Input.GetMouseButtonDown(0));
        }
    }
} 
