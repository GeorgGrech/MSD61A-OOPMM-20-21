using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GameObject myenemyPrefab;

    Coroutine myCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            myenemyPrefab = Resources.Load("prefabs/Enemy") as GameObject;
            Vector3 myenemyPos = new Vector3(Random.Range(GameData.XMin, GameData.XMax), GameData.YMax, 0f);
            Instantiate(myenemyPrefab, myenemyPos, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

}
