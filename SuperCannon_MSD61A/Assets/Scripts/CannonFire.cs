using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour

{
    //Repeated firing Coroutine
    public IEnumerator RepeatedFire(string prefabToLoad, float waitTime)
    {
        GameObject mybulletPrefab = Resources.Load(prefabToLoad) as GameObject;
        while (true)
        {
            Instantiate(mybulletPrefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
            yield return new WaitForSeconds(waitTime);
        }
    }
}





