using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class AzureMine : MonoBehaviour
{
    [SerializeField] public MoneyScript moneyScript;
    [SerializeField] public AzureCountdown azureCountdown;
    //
    public AudioSource buttonPressedNoise;
    public float delayPress;
    public BigInteger newWorth;
    public BigInteger azureValue;
    public Button azureMineButton;

    void Start()
    {
        delayPress = 0.5f;
        newWorth = 5;
        azureValue = 5;
    }

    public void onPress()
    {
        buttonPressedNoise.Play();
        azureMineButton.interactable = false;
        azureCountdown.increaseBar();
        Invoke("delay", delayPress);
    }

    public void delay()
    {
        azureMineButton.interactable = true;
    }
}
