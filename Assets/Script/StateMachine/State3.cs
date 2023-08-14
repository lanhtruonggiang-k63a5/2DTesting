using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

public class State3 : State
{
    private void OnEnable() {
        Debug.Log(this.name + " state 3 ", gameObject);
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.F)) ChangeState("StateCustom");

    }
}
