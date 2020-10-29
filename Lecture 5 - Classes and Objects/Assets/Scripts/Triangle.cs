using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Shape mytriangle = new Shape(2f, 0f);
        Rigidbody2D mytriangleBody = this.gameObject.GetComponent<Rigidbody2D>();
        mytriangle.MoveLeft(mytriangleBody);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
