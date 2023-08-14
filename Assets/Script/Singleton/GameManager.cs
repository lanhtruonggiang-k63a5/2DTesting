using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class GameManager : Singleton<GameManager>
{
    public void PrintBruh()
    {
        if (Input.GetKey(KeyCode.Space)) Debug.Log(this + " go bruh  ", gameObject);
    }
}
