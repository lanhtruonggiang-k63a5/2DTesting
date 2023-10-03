using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.Utilities;

public class TestInlineButton : MonoBehaviour
{
    // Inline Buttons:
    [InlineButton("A")]
    public int InlineButton;

    [InlineButton("A")]
    [InlineButton("B", "Custom Button Name")]
    public int ChainedButtons;

    [InlineButton("ResetValue")]
    public const int CONST_VALUE = 0;
    public int value = CONST_VALUE;
    private void ResetValue() => value = CONST_VALUE;

    private void A() => Debug.Log("A");

    private void B() => Debug.Log("B");
}
