using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject leftBound = GameObject.Find("LeftBoundary");
        leftBound.transform.position = new Vector3(GameData.XMin - 1, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
