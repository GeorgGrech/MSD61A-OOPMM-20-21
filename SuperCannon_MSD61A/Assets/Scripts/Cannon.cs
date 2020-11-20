using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private Vector3 mousePos;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // mousePos = new Vector3(mousePos.x, mousePos.y, 0);
      //  Debug.Log(mousePos);
        Quaternion newrotation = Quaternion.LookRotation(transform.position - GameData.MouseTarget, new Vector3(0,0,1));
      //  Debug.Log(GameData.XMax);
        newrotation.x = 0f;
        newrotation.y = 0f;
        //transform.rotation = newrotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, newrotation, Time.deltaTime * 4);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject mybulletPrefab = Resources.Load("prefabs/SmallBullet") as GameObject;
            Instantiate(mybulletPrefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            GameObject mybulletPrefab = Resources.Load("prefabs/LargeBullet") as GameObject;
            Instantiate(mybulletPrefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
        }


    }
}
