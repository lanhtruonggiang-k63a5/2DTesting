using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


//Slot on Board
public class BoardSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {   
        GameObject item = eventData.pointerDrag;
        DraggableItem draggableItem = item.GetComponent<DraggableItem>();
        draggableItem.parentAfterDrag = transform;
    }
}
