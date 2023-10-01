using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class AzureMine : MonoBehaviour
{
    [SerializeField] MoneyScript moneyScript;
    [SerializeField] AzureCountdown azureCountdown;
    //
    public BigInteger coalValue;
    public Button azureMineButton;

    void Start()
    {
        coalValue = 5;
    }

    public void onPress()
    {
        azureMineButton.interactable = false;
        azureCountdown.increaseBar();
        Invoke("delay", 0.5f);
    }

    public void delay()
    {
        azureMineButton.interactable = true;
    }
}
