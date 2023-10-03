using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckPointer : MonoBehaviour, IPointerDownHandler,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData) { 
        Debug.Log(this.name + $" pointer click :  "  , gameObject);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.name + $" pointer down  "  , gameObject);
    }
}
