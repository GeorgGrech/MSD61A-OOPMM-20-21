using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCannon : MonoBehaviour
{
    private Vector3 mousePos;

    private CannonFire cannonfiring;
    private Coroutine fire2CoRoutine;
    // Start is called before the first frame update
    void Start()
    {
        cannonfiring = GetComponent<CannonFire>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire2"))
        {
            fire2CoRoutine = StartCoroutine(cannonfiring.RepeatedFire("prefabs/LargeBullet", 1f));
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            StopCoroutine(fire2CoRoutine);
        }
      

    }
}

