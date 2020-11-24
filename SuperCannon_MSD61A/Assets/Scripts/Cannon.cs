using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private Vector3 mousePos;
    Coroutine fire1CoRoutine, fire2CoRoutine;
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
        Quaternion newrotation = Quaternion.LookRotation(transform.position - GameData.MouseTarget, new Vector3(0, 0, 1));
        //  Debug.Log(GameData.XMax);
        newrotation.x = 0f;
        newrotation.y = 0f;
        //transform.rotation = newrotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, newrotation, Time.deltaTime * 4);

        if (Input.GetButtonDown("Fire1"))
        {
            fire1CoRoutine = StartCoroutine(RepeatedFire("prefabs/SmallBullet", 0.5f));
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(fire1CoRoutine);
        }


        if (Input.GetButtonDown("Fire2"))
        {
            fire2CoRoutine = StartCoroutine(RepeatedFire("prefabs/LargeBullet", 1f));
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            StopCoroutine(fire2CoRoutine);
        }

        IEnumerator RepeatedFire(string prefabToLoad, float waitTime)
        {
            while (true)
            {
                GameObject mybulletPrefab = Resources.Load(prefabToLoad) as GameObject;
                Instantiate(mybulletPrefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
                yield return new WaitForSeconds(waitTime);
            }
        }

    }
}
