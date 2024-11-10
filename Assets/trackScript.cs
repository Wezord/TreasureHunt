using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class trackScript : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    
    void OnEnable(){
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable(){
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
        Manager.current.IsDetected = false;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs){
        foreach(var trackedImage in eventArgs.added){
            Debug.Log("Image tracked : " + trackedImage.referenceImage.name);
        }
        Manager.current.IsDetected = true;
    }
}
