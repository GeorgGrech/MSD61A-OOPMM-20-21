using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{

    private static int _score = 0;

    //CREATE A GETTER
    public static Vector3 MouseTarget
    {
        get { return GetTarget(); }
    }


    private static Vector3 GetTarget()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y, 0);
      //  Debug.Log(mousePos);
        return mousePos;
    }

    //CREATE GETTER AND SETTER FOR SCORE
    public static int Score
    {
        get { return _score; }
        set { _score = value; }
    }



    public static float XMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;  }
    }

    public static float XMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x; }
    }

    public static float YMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y; }
    }

    public static float YMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y; }
    }




}
