using UnityEngine;
using Pixelplacement;

public class SplineTweener : MonoBehaviour
{
    public Spline mySpline;
    public Transform myObject;

    void Awake()
    {
        Tween.Spline(mySpline, myObject, 0, 1, false, 2, 0, Tween.EaseInOut, Tween.LoopType.PingPong);
    }
}