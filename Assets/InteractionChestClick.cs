using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractionChestClick : MonoBehaviour, IPointerClickHandler
{
    private bool isClick = false;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked: ");
        Manager.current.ClickedObject = eventData.pointerCurrentRaycast.gameObject;
        if (Manager.current.ClickedObject != null)
        {
            Manager.current.Count++;
            if(isClick){
                Manager.current.IsOpen = true;
                isClick = false;
            }
            else {
                Manager.current.IsOpen = false;
                isClick = true;
            }
        }
    }
}
