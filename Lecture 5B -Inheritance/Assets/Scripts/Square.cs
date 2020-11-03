using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{

    // Start is called before the first frame update
    void Start()
    {
        //  Shape mysquare = new Shape(1f, 0f);
        Rigidbody2D mysquareBody = this.gameObject.GetComponent<Rigidbody2D>();
        MoveRight(mysquareBody);
        
    }

    protected override void MoveRight(Rigidbody2D myshape)
    {
        
        base.speed = new Vector2(2f, 0);
        base.MoveRight(myshape);
        myshape.rotation = +45;
    }

}
