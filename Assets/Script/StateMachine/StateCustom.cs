using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

public class StateCustom : State
{
    private void OnEnable() {
        Debug.Log(this.name + " state_1 ", gameObject);
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.F)) ChangeState("State2");

    }
}
