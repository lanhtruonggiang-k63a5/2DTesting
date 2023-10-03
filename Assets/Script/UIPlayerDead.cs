using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class UIPlayerDead : MonoBehaviour
{
    public event Action UIAction;
    private void Start() {
        Player.unityEvent.AddListener(UIDead);    
        // Player.unityEvent+= UIDead;      runtime-bug(phải gọi qua api)        
        Player.onDead+=UIDead;
        //Player.onDead=UIDead;             runtime-bug(event ko cho ghi đè)
        // UIAction= Player.onDead;         runtime-bug(event ko truyền giá trị)
        // Player.onDead();                 runtime-bug(event ko cho call từ class)
    }
    public void UIDead(){

    }


}
