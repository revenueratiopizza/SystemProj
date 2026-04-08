using System.Collections;
using UnityEngine;
// https://www.youtube.com/watch?v=qrr4BGRcv3I
// https://www.youtube.com/watch?v=_4TRkQK7nNs
// https://www.youtube.com/watch?v=7qvuuQ1oCMk
public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    IEnumerator ZombieSpawning()
    {
        // It seems as though while(true) is an infinite loop
        // https://www.reddit.com/r/C_Programming/comments/u0ibw7/what_is_the_fastest_and_best_way_to_do_an/
        // Good to know
        while (true)
        {
            // Remake the random spawn floats every time we run the coroutine just for good measure
            float zombieSpawnX = Random.Range(-10f, 10f);
            float zombieSpawnY = Random.Range(-6f, 6f);
            // And then we use these two values to randomize a zombie's spawn position
            Vector2 spawnPosition = new Vector2(zombieSpawnX, zombieSpawnY);
            Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);
            // And we do that every 0.1-1 seconds and loop
            yield return new WaitForSeconds(Random.Range(0.1f, 1f));
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ZombieSpawning());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
