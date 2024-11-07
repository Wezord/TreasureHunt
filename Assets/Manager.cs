using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    private int count = 0;
    private GameObject clickedObject;
    public static Manager current;

    private void Awake(){
        if (current == null){
            current = this;
        }
        else {
            Destroy(obj : this);
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
