using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

public class AzureUpgrade : MonoBehaviour
{
    
    //
    public AzureMine azureMine;
    public MoneyScript moneyScript;
    //
    public int azureValueMultiplier = 1;
    public float multiplier = 1.2f;
    [SerializeField] private float minusByTotal;
    [SerializeField] private BigInteger bigMinusByTotal;
    public TextMeshProUGUI cost;


    void Start()
    {
        minusByTotal = 20;
        cost.text = "$" + minusByTotal.ToString ();
    }

    public void onPress()
    {
        if (bigMinusByTotal <= moneyScript.totalMoney)
        {
            moneyScript.minus = bigMinusByTotal;
            moneyScript.decreaseMoney();
            azureMine.newWorth = (BigInteger)((double)(azureMine.azureValue * azureValueMultiplier) * multiplier);
            multiplier = multiplier * 1.2f;
            multiplier = Mathf.Round(multiplier * 100f) / 100f;
            minusByTotal = Mathf.Round(minusByTotal * 1.3f);
            bigMinusByTotal = (BigInteger)minusByTotal;
            cost.text = "$" + bigMinusByTotal.ToString();
        }
            
        
    }    
}
