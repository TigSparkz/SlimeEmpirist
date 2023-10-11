using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public AudioSource spentMoney;
    public AudioSource gainedMoney;
    public TextMeshProUGUI moneyText;
    public BigInteger totalMoney;
    public BigInteger add;
    public BigInteger minus;

    void Start()
    {
        add = 0;
        totalMoney = 0;
    }

    public void increaseMoney()
    {
        gainedMoney.Play();
        totalMoney = totalMoney + add;
        moneyText.text = totalMoney.ToString();
        add = 0;
    }
    public void decreaseMoney()
    {
        spentMoney.Play();
        totalMoney = totalMoney - minus;
        moneyText.text = totalMoney.ToString();
        minus = 0;
    }
}
