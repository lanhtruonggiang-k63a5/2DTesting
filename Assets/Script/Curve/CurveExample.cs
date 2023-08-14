using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class CurveExample : MonoBehaviour
{



    public Spline _mySpline;
    public Transform box;
    private void Start() {
        _mySpline = GetComponent<Spline>();
    }
    void Awake()
    {
        Tween.Spline(_mySpline, box,0, 1, true, 3, 0, Tween.EaseInOut, Tween.LoopType.PingPong);
    }
}





