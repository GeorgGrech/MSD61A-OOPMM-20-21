using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GameObject myenemyPrefab;

    private int enemychoice;
    Coroutine myCoroutine;

    [SerializeField] List<GameObject> enemiesList;
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
            enemychoice = Random.Range(0, enemiesList.Count);
            Vector3 myenemyPos = new Vector3(Random.Range(GameData.XMin, GameData.XMax), GameData.YMax, 0f);
            Instantiate(enemiesList[enemychoice], myenemyPos, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

}
