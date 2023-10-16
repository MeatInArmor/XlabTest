using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLabTest;

namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;
        //private bool isGameOver = false;

        public float MaxDelay;
        public float Minelay;

        public float delay;
        public float delayStep;
        public float spawnDeltatime;

        public int score;
        public int hightScore;

        public List<GameObject> stones = new List<GameObject>(16);
        public Player player;

        public void ClearStones()
        {
            foreach(var stone in stones)
            {
                Destroy(stone);
            }
            stones.Clear();
        }
        private void Start()
        {
            MaxDelay = 4f;
            Minelay = 1f;
            delayStep = 0.05f;
            spawnDeltatime = 0f;
            //spawnDeltatime = Time.time;
            //Debug.Log(MaxDelay);
            //Debug.Log(Minelay);
            //StartCoroutine(SpawnStoneProc());
            RefreshDelay();
        }
 
        private void OnEnable()
        {
            GameEvents.onStickHit += OnStickHit;
            score = 0;
        }
        private void OnDisable()
        {
            GameEvents.onStickHit -= OnStickHit;
            player.SetDown(false);
        }
        private void OnStickHit()
        {
            score++;
            hightScore = Mathf.Max(hightScore, score);
            Debug.Log($"total score: {score};\n hight score: {hightScore}");
        }

        private void Update()
        {
            spawnDeltatime += Time.deltaTime;
            // if (!isGameOver)    
            if (spawnDeltatime >= delay)
            {
                var stone = spawner.Spawn();
                stones.Add(stone);
                //spawnDeltatime = Time.time;
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
            spawnDeltatime = 0f;
            delay = UnityEngine.Random.Range(Minelay, MaxDelay);
            MaxDelay = Mathf.Max(Minelay, MaxDelay - delayStep);
            Debug.Log(delay);
            //if (MaxDelay > Minelay)
            //    MaxDelay -= delayStep;
        }
        IEnumerator WaitEvent(System.Action callBack)
        {
            yield return new WaitForSeconds(delay);
            callBack?.Invoke();
        }
    }
}