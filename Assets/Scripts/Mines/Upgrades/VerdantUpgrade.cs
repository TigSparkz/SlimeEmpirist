using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

public class VerdantUpgrade : MonoBehaviour
{
    
    //
    public VerdantMine verdantMine;
    public MoneyScript moneyScript;
    //
    public int verdantValueMultiplier = 1;
    public float multiplier = 1.4f;
    [SerializeField] private float minusByTotal;
    [SerializeField] private BigInteger bigMinusByTotal;
    public TextMeshProUGUI cost;


    void Start()
    {
        bigMinusByTotal = 50;
        minusByTotal = 50;
        cost.text = "$" + minusByTotal.ToString ();
    }

    public void onPress()
    {
        if (bigMinusByTotal <= moneyScript.totalMoney)
        {
            moneyScript.minus = bigMinusByTotal;
            moneyScript.decreaseMoney();
            verdantMine.newWorth = (BigInteger)((double)(verdantMine.verdantValue * verdantValueMultiplier) * multiplier);
            multiplier = multiplier * 1.4f;
            multiplier = Mathf.Round(multiplier * 100f) / 100f;
            minusByTotal = Mathf.Round(minusByTotal * 1.45f);
            bigMinusByTotal = (BigInteger)minusByTotal;
            cost.text = "$" + bigMinusByTotal.ToString();
        }
            
        
    }    
}
