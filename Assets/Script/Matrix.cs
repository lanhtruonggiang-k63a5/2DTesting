using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEditor;
using UnityEngine;

public class Matrix : SerializedMonoBehaviour
{
    [TableMatrix(DrawElementMethod = "DrawCell")]
    public bool[,] CustomCelDrawing;

    private static bool DrawCell(Rect rect, bool value) {
        if(Event.current.type == EventType.MouseDown
        && rect.Contains(Event.current.mousePosition)){
            value = !value;
            GUI.changed = true;
            Event.current.Use();
        }
        EditorGUI.DrawRect(rect.Padding(1),
        value ? new Color(0.1f,0.8f,0.2f)
        : new Color(0,0,0,0.5f));
        return value;
     }
}
