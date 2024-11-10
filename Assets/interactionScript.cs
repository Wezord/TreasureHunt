using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class interactionScript : MonoBehaviour
{
    private Boolean isClick = false;
    private Boolean isHolding = false;
    private float clickStartTime;
    private float holdThreshold;
    private Vector3 firstPoint;
    private Vector3 lastPoint;
    private int count;
    private GameObject clickedObject;
    public static interactionScript current;
    // Start is called before the first frame update

    private void Awake(){
        if (current == null){
            current = this;
        }
        else {
            Destroy(obj : this);
        }
    }

    void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked: ");
        current.ClickedObject = eventData.pointerCurrentRaycast.gameObject;
        if (clickedObject != null)
        {
            current.Count++;
            Renderer renderer = clickedObject.GetComponent<Renderer>();
            
            if (renderer != null)
            {
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

    public event Action<int> onCountChange;
    public void CountChange(int newcount){
        onCountChange?.Invoke(newcount);
    }

    public event Action<GameObject> onObjectChange;
    public void ObjectChange(GameObject newObject){
        onObjectChange?.Invoke(newObject);
    }

    public GameObject ClickedObject{
        get=>clickedObject;
        set{
            clickedObject = value;
            ObjectChange(value);
        }
    }

    public int Count{
        get=>count;
        set{
            count = value;
            CountChange(value);
        }
    } 
}
