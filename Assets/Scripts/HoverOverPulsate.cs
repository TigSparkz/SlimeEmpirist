using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HoverOverPulsate : MonoBehaviour
{

    public TextMeshProUGUI textToShrink;

    void Start()
    {
        textToShrink.fontSize = 20;
    }

    
    void Update()
    {
        
    }

    public void OnMouseDown ()
    {
        textToShrink.fontSize = 13;
    }
    public void OnMouseUp()
    {
        textToShrink.fontSize = 20;
    }
    


}
