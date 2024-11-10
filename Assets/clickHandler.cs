using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour, IPointerClickHandler
{
    private Boolean isClick = false;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked: ");
        Manager.current.ClickedObject = eventData.pointerCurrentRaycast.gameObject;
        if (Manager.current.ClickedObject != null)
        {
            Manager.current.Count++;
            Renderer renderer = Manager.current.ClickedObject.GetComponent<Renderer>();
        
            if(isClick){
                renderer.material.color = Color.white;
                isClick = false;
            }
            else {
                renderer.material.color = Color.red;
                isClick = true;
            }
        }
    }
}
