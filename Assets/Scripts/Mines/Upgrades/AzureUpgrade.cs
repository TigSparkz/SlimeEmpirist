using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

public class AzureUpgrade : MonoBehaviour
{
    
    //
    [SerializeField] AzureMine azureMine;
    [SerializeField] MoneyScript moneyScript;
    //
    public float minusByTotal;
    public float azureMineLevel;
    public TextMeshProUGUI cost;
    public BigInteger total;

    void Start()
    {
        minusByTotal = 20;
        azureMineLevel = 1.3f;
        cost.text = "$" + minusByTotal.ToString ();
    }

    public void onPress()
    {
        if ((BigInteger)minusByTotal <= moneyScript.totalMoney)
        {
            moneyScript.minus = (BigInteger)minusByTotal;
            moneyScript.decreaseMoney();
            azureMine.azureValue = (BigInteger)((double)azureMine.azureValue * 1.2f);
            minusByTotal = (int)(minusByTotal * 1.3f);
            cost.text = "$" + minusByTotal.ToString();
        }
            
        
    }    
}
