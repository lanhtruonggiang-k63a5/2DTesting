using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Slot for the box
public class InventorySlot : MonoBehaviour, IDropHandler
{
    private Transform inventory;
    private void Start() => inventory = transform.parent;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject item = eventData.pointerDrag;
        DraggableItem draggableItem = item.GetComponent<DraggableItem>();

        if (transform.childCount == 0) draggableItem.parentAfterDrag = transform;

        if (transform.childCount >= 1)
            foreach (Transform slot in inventory)
            {
                if (slot.childCount == 0) draggableItem.parentAfterDrag = slot;
            }
    }


}
