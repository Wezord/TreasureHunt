using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class interactionScript : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked: ");
        GameObject clickedObject = eventData.pointerCurrentRaycast.gameObject;
        if (clickedObject != null)
        {
            Renderer renderer = clickedObject.GetComponent<Renderer>();
            if (renderer != null)
            {
            renderer.material.color = Color.red;
            }
        }
    }
}
