using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    private GameObject myballprefab;
    private GameObject mytriangleprefab;
    // Start is called before the first frame update
    void Start()
    {
        myballprefab = Resources.Load("Circle") as GameObject;
        mytriangleprefab = Resources.Load("Triangle") as GameObject;
        GameObject mycircle = Instantiate(myballprefab, new Vector3(-6f,-2f,0),Quaternion.identity);
        GameObject mytriangle = Instantiate(mytriangleprefab, new Vector3(6f,2f,0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
