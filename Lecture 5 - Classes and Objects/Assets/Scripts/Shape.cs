using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 speed = new Vector2(1f, 0f);

    public void MoveRight(Rigidbody2D myshape)
    {
        myshape.velocity = speed;

    }

    public void MoveLeft(Rigidbody2D myshape)
    {
        myshape.velocity = -speed;

    }


}
