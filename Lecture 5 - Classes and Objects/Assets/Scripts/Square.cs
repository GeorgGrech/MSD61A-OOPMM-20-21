using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Shape mysquare = new Shape(1f, 0f);
        Rigidbody2D mysquareBody = this.gameObject.GetComponent<Rigidbody2D>();
        mysquare.MoveRight(mysquareBody);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
