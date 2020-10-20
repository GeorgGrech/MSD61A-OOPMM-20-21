using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Shape
{
    // Start is called before the first frame update
    Rigidbody2D mytriangle;

    void Start()
    {
        mytriangle = this.gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
        MoveLeft(mytriangle);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
