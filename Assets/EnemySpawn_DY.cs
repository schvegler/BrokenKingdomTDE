using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn_DY : MonoBehaviour
{
    //Reference of the gameobject to instantiate
    public GameObject enemy;

    //Wait for random time between min/max
    public float  waitMin = 60;
    public float waitMax = 120;

    public int maxEnemySpawn = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();    
    }

    //Starting the coroutine
    public void SpawnEnemy() {
        StartCoroutine(EnemySpawner());
    }

    //Instantiate enemy, wait, repeat
    IEnumerator EnemySpawner() {

        //UI joystick does conflict if player and enemy spanw at the same time - start with wait !!!

        for (int i = 0; i < transform.childCount; i++)
        {
            if (!transform.GetChild(i).gameObject.activeSelf)
            {
                Destroy(transform.GetChild(i).gameObject);
            }
        }

        yield return new WaitForSeconds(Random.Range(waitMin, waitMax));
        

        if (gameObject.transform.childCount <= maxEnemySpawn + 2)
        {
            Instantiate(enemy, gameObject.transform);
        }

        StartCoroutine(EnemySpawner());
    }


}
