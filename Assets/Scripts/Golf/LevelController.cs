using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLabTest;

public class LevelController : MonoBehaviour
{
    public Spawner spawner;
    public bool isGameOver = false;
    public float spawnDeltatime;

    public float MaxDelay = 2f;
    public float Minelay = 0.5f;

    public float delay = 50f;


    private void Start()
    {
        //StartCoroutine(SpawnStoneProc());
        spawnDeltatime = Time.time;
    }

    private void Update()
    {
        if (!isGameOver)    
            if(spawnDeltatime + delay <= Time.time) 
            {
                //Debug.Log(Time.time);
                //Debug.Log(spawnDeltatime + delay);
                spawner.Spawn();
                spawnDeltatime = Time.time;
            }
    }
    private IEnumerator SpawnStoneProc()
    {
        do
        {
            yield return new WaitForSeconds(delay);
            spawner.Spawn();
        } while (isGameOver);
    }
    public void RefreshDelay()
    {
        
    }
}
