using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI interactionText;
    public TextMeshProUGUI detectionText;
    // Start is called before the first frame update
    void Start()
    {
        Manager.current.onCountChange += changeScore;
        Manager.current.onDetectionChange += changeDetection;
    }

    void changeScore(int newScore){
        Debug.Log("Score changed to: " + newScore);
        interactionText.text = "Nombre d'interactions : " + newScore;
    }

    void changeDetection(bool newDetection){
        if(Manager.current.IsDetected){
            detectionText.text = "Objet détecté !";
            detectionText.color = Color.green;
        }
        else{
            detectionText.text = "Objet non détecté !";
            detectionText.color = Color.red;
        }
    }
}
