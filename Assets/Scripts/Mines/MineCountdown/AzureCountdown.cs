using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class AzureCountdown : MonoBehaviour
{
    [SerializeField] MoneyScript moneyScript;
    [SerializeField] AzureMine azureMine;
    //
    public float nextamount;
    public float fillAmount;
    public Image bar;
    

    void Start()
    {
        fillAmount = 0;
        nextamount = 0;
    }


    void Update()
    {
        if (fillAmount >= 1)
        {
            fillAmount = 0;
            bar.fillAmount = fillAmount;
            moneyScript.add = azureMine.coalValue;
            moneyScript.increaseMoney();
        }
    }
    public void increaseBar()
    {
        nextamount = fillAmount + 0.2f;
        if (fillAmount <= 1 && nextamount != fillAmount)
        {
            InvokeRepeating("increase", 0.01f, 0.01f);
        }

    }
    public void increase()
    {
        fillAmount += 0.01f;
        bar.fillAmount = fillAmount;
        if (fillAmount >= nextamount)
        {
            fillAmount = nextamount;
            bar.fillAmount = fillAmount;
            CancelInvoke();
        }
    }

}
