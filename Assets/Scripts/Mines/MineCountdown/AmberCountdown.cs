using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class AmberCountdown : MonoBehaviour
{
    public MoneyScript moneyScript;
    public AmberMine amberMine;
    //
    public float totalInc;
    public float fillUpBy;
    [SerializeField] private float nextamount;
    public float fillAmount;
    [SerializeField] private Image bar;
    

    void Start()
    {
        totalInc = 0.2f;
        fillUpBy = 0.005f;
        fillAmount = 0;
        nextamount = 0;
    }


    void Update()
    {
        if (fillAmount >= 1)
        {
            nextamount = 0;
            fillAmount = 0;
            bar.fillAmount = fillAmount;
            moneyScript.add = amberMine.newWorth;
            moneyScript.increaseMoney();
        }
    }
    public void increaseBar()
    {
        nextamount = nextamount + totalInc;
        if (fillAmount <= 1 && fillAmount < nextamount)
        {
            InvokeRepeating("increase", 0, 0.01f);
        }

    }
    public void increase()
    {
        if (fillAmount < nextamount)
        {
            fillAmount += fillUpBy;
            bar.fillAmount = fillAmount;
        }
        if (fillAmount >= nextamount)
        {
            fillAmount = nextamount;
            bar.fillAmount = fillAmount;
            CancelInvoke();
        }
    }

}