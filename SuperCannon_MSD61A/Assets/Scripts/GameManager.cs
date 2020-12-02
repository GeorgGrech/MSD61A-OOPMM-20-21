using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ITakeDamage

{

    int health { get; set; }
    void TakeDamage(int damage);
}


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject leftBound = GameObject.Find("LeftBoundary");
        leftBound.transform.position = new Vector3(GameData.XMin - 2, 0f, 0f);

        GameObject rightBound = GameObject.Find("RightBoundary");
        rightBound.transform.position = new Vector3(GameData.XMax + 2, 0f, 0f);

        GameObject topBound = GameObject.Find("TopBoundary");
        topBound.transform.position = new Vector3(0f, GameData.YMax + 2, 0f);

        GameObject bottomBound = GameObject.Find("BottomBoundary");
        bottomBound.transform.position = new Vector3(0f, GameData.YMin - 2, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
