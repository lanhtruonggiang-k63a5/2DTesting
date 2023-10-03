using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSizeDelta : MonoBehaviour
{
    [SerializeField] RectTransform pictureRT;
    
    private void Start() {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
