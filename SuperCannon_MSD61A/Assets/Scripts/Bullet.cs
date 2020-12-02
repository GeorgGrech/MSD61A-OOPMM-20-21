using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float speed = 5;
    private Vector3 mousePos;
    protected Vector2 direction;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        //mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // mousePos = new Vector3(mousePos.x, mousePos.y, 0);
        // Debug.Log(mousePos);
        Debug.Log("YMin: " + GameData.YMin);
        direction = GameData.MouseTarget - new Vector3(0f, GameData.YMin, 0f);
        ApplyBulletVelocity();
    }

    protected virtual void ApplyBulletVelocity()
    {
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;

    }


    protected void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Boundary")
        {
            Debug.Log("Leaving screen");
            Destroy(this.gameObject);
        }

        if (other.gameObject.name.Contains("Enemy"))
        {
            GameData.Score++;
          //  Destroy(other.gameObject);
          //  Destroy(this.gameObject);
        }
    }


}
