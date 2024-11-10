using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI interactionText;
    // Start is called before the first frame update
    void Start()
    {
        Manager.current.onCountChange += changeScore;
    }

    void changeScore(int newScore){
        Debug.Log("Score changed to: " + newScore);
        interactionText.text = "Nombre d'interactions : " + newScore;
    }
}
