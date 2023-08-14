using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using Pixelplacement.TweenSystem;

public class TweenExample : MonoBehaviour
{
    public List<Transform> transforms;
    public Transform parent;

    public Spline _mySpline;
    private void Start()
    {
        foreach (Transform child in parent)
        {
            transforms.Add(child);
        }
        LocalPosition();
        Position();
        LocalScale();
        LocalRotation();
        Rotation();
        Rotate();
        Shake();
        Spline();        

    }
    private void LocalPosition()
    {
         // up-down loop
        var tween = Tween.LocalPosition(transforms[0],Vector3.up*10, 2f,2f ,
         Tween.EaseBounce, Tween.LoopType.Loop,
         null,null, false);
    }
    private void Position()
    {
        var tween = Tween.Position(transforms[1], Vector3.up * 10, 2f, 2f,
         Tween.EaseIn, Tween.LoopType.PingPong,
         null, null, false);
    }
    private void LocalScale()
    {
        var tween = Tween.LocalScale(transforms[2], Vector3.up * 10, 2f, 2f,
         Tween.EaseInBack, Tween.LoopType.PingPong,
         null, null, false);
    }
    private void LocalRotation()
    {
        var tween = Tween.LocalRotation(transforms[3], Vector3.up * 10, 2f, 2f,
         Tween.EaseInOut, Tween.LoopType.PingPong,
         null, null, false);
    }
    private void Rotation()
    {
        var tween = Tween.Rotation(transforms[4], Vector3.up * 10, 2f, 2f,
         Tween.EaseInOutBack, Tween.LoopType.PingPong,
         null, null, false);
    }
    private void Rotate()
    {
        var tween = Tween.Rotate(transforms[5], Vector3.up * 10,Space.Self,2f,2f,
        Tween.EaseInOutStrong,Tween.LoopType.PingPong,
        null,null,false);
    }
    private void Shake()
    {
        var tween = Tween.Shake(transforms[6], transforms[4].position,Vector3.one*0.5f,2f,2f,
          Tween.LoopType.PingPong,
         null, null, false);
    }
    private void Spline()
    {
        

    var tween = Tween.Spline(_mySpline ,transforms[7],0f,100f,true, 2f, 2f,
         Tween.EaseInStrong, Tween.LoopType.PingPong,
         null, null, false);
    }

    




}
