using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenShopScreen : MonoBehaviour
{
    public Button button;
    public Image backgroundImage;


    void Start()
    {
        backgroundImage.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }


    public void openShop()
    {
        if (backgroundImage.gameObject.activeSelf == true)
        {
            backgroundImage.gameObject.SetActive(false);
        }
        else
        {
            backgroundImage.gameObject.SetActive(true);
        } 
        
    }
    
}
