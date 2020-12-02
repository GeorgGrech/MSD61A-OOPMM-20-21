using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCannon : MonoBehaviour
{
    private Vector3 mousePos;

    private CannonFire cannonfiring;
    private Coroutine fire1CoRoutine;
    // Start is called before the first frame update
    void Start()
    {
        cannonfiring = GetComponent<CannonFire>();
    }

    // Update is called once per frame
    void Update()
    {
   

        Quaternion newrotation = Quaternion.LookRotation(transform.position - GameData.MouseTarget, new Vector3(0, 0, 1));
        //  Debug.Log(GameData.XMax);
        newrotation.x = 0f;
        newrotation.y = 0f;
        //transform.rotation = newrotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, newrotation, Time.deltaTime * 4);

        if (Input.GetButtonDown("Fire1"))
        {
            fire1CoRoutine = StartCoroutine(cannonfiring.RepeatedFire("prefabs/SmallBullet", 0.5f));
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(fire1CoRoutine);
        }

    }
}

