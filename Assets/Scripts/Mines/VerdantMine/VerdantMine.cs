using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class VerdantMine : MonoBehaviour
{
    [SerializeField] public MoneyScript moneyScript;
    [SerializeField] public VerdantCountdown verdantCountdown;
    //
    public AudioSource buttonPressedNoise;
    public float delayPress;
    public BigInteger newWorth;
    public BigInteger verdantValue;
    public Button verdantMineButton;

    void Start()
    {
        delayPress = 1.3f;
        newWorth = 35;
        verdantValue = 35;
    }

    public void onPress()
    {
        buttonPressedNoise.Play();
        verdantMineButton.interactable = false;
        verdantCountdown.increaseBar();
        Invoke("delay", delayPress);
    }

    public void delay()
    {
        verdantMineButton.interactable = true;
    }
}
