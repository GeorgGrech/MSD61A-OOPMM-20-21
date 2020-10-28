using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Shape myshape = new Shape();
        Rigidbody2D mysquare = this.gameObject.GetComponent<Rigidbody2D>();
        myshape.MoveRight(mysquare);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
