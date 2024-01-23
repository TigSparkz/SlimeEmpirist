using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class AmberMine : MonoBehaviour
{
    [SerializeField] public MoneyScript moneyScript;
    [SerializeField] public AmberCountdown amberCountdown;
    //
    public AudioSource buttonPressedNoise;
    public float delayPress;
    public BigInteger newWorth;
    public BigInteger amberValue;
    public Button amberMineButton;

    void Start()
    {
        delayPress = 0.8f;
        newWorth = 15;
        amberValue = 15;
    }

    public void onPress()
    {
        buttonPressedNoise.Play();
        amberMineButton.interactable = false;
        amberCountdown.increaseBar();
        Invoke("delay", delayPress);
    }

    public void delay()
    {
        amberMineButton.interactable = true;
    }
}
