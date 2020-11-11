using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float speed = 2;
    private Vector3 mousePos;
    private Vector2 direction;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y, 0);
        Debug.Log(mousePos);
        direction = mousePos - new Vector3(0f, -8f, 0f);
        GetComponent<Rigidbody2D>().velocity = direction * speed;

    }


}
