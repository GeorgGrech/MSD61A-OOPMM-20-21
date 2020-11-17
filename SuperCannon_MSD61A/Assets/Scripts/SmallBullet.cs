using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : Bullet
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.speed = 10;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer mysprite = this.gameObject.GetComponent<SpriteRenderer>();
        float newalpha = mysprite.color.a - 0.005f;
        mysprite.color = new Color(mysprite.color.r, mysprite.color.g, mysprite.color.b, newalpha);
        if (mysprite.color.a <= 0) Destroy(this.gameObject);


    }
}
