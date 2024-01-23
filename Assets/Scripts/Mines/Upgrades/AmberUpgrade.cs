using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

public class AmberUpgrade : MonoBehaviour
{
    
    //
    public AmberMine amberMine;
    public MoneyScript moneyScript;
    //
    public int amberValueMultiplier = 1;
    public float multiplier = 1.3f;
    [SerializeField] private float minusByTotal;
    [SerializeField] private BigInteger bigMinusByTotal;
    public TextMeshProUGUI cost;


    void Start()
    {
        bigMinusByTotal = 35;
        minusByTotal = 35;
        cost.text = "$" + minusByTotal.ToString ();
    }

    public void onPress()
    {
        if (bigMinusByTotal <= moneyScript.totalMoney)
        {
            moneyScript.minus = bigMinusByTotal;
            moneyScript.decreaseMoney();
            amberMine.newWorth = (BigInteger)((double)(amberMine.amberValue * amberValueMultiplier) * multiplier);
            multiplier = multiplier * 1.3f;
            multiplier = Mathf.Round(multiplier * 100f) / 100f;
            minusByTotal = Mathf.Round(minusByTotal * 1.35f);
            bigMinusByTotal = (BigInteger)minusByTotal;
            cost.text = "$" + bigMinusByTotal.ToString();
        }
            
        
    }    
}
