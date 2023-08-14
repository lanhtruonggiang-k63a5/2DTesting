using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

public class State2 : State
{
    private void OnEnable() {
        Debug.Log(this.name + " state 2 ", gameObject);
        
    }
    private void Update() {
        if(Input.GetKey(KeyCode.F)) ChangeState("State3") ;
        
    }
}
