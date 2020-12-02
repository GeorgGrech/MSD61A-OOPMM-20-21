using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour, ITakeDamage
{
    // Start is called before the first frame update

    public int health { get; set; }
    
    public void TakeDamage(int damage)
    {
        Debug.Log(health);
        health = health - damage;
        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0.2f, 0.2f, 0.2f, 0.2f);
        if (health <= 0) Destroy(this.gameObject);

    }
}
