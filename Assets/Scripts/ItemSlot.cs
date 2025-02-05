using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData)
    {

        GameObject dropped = eventData.pointerDrag;

        DraggableObject draggableObject = dropped.GetComponent<DraggableObject>();
        
        draggableObject.parentAfterDrag = transform;
    
        Debug.Log(transform.name);
    }
}
