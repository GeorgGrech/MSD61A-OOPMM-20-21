using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    // Start is called before the first frame update
    Rigidbody2D mycircle;

    void Start()
    {
        mycircle = this.gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
        MoveRight(mycircle);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
