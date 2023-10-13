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

    public float delay = 10f;
    public float delayStep = 0.1f;

    private void Start()
    {
        //StartCoroutine(SpawnStoneProc());
        spawnDeltatime = Time.time;
        RefreshDelay();
        StartCoroutine(WaitEvent());
    }

    private void OnFinishWaitEvent()
    {
        Debug.Log("1");
    }

    private void OnEnable()
    {
        GameEvents.onCollisionStone += GameOver;
        GameEvents.onClickHit += OnClickHit;
    }
    private void OnDisable()
    {
        GameEvents.onCollisionStone -= GameOver;
        GameEvents.onClickHit -= OnClickHit;
    }
    private void GameOver()
    {

    }
    private void OnClickHit()
    {

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
                RefreshDelay();
            }
    }
    //private IEnumerator SpawnStoneProc()
    //{
    //    do
    //    {
    //        yield return new WaitForSeconds(delay);
    //        spawner.Spawn();
    //    } while (isGameOver);
    //}
    public void RefreshDelay()
    {
        delay = UnityEngine.Random.Range(Minelay, MaxDelay);
        MaxDelay = Mathf.Max(Minelay, MaxDelay - delayStep);
    }
    IEnumerator WaitEvent()
    {
        yield return new WaitForSeconds(delay); 
    }
}
