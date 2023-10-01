using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AzureUpgrade : MonoBehaviour
{
    [SerializeField] AzureMine azureMine;
    [SerializeField] MoneyScript moneyScript;
    //
    public int minusByTotal;
    public int coalMineLevel;
    public TextMeshProUGUI cost;

    void Start()
    {
        minusByTotal = 100;
        coalMineLevel = 1;
        cost.text = "$" + minusByTotal.ToString ();
    }

    public void onPress()
    {
        if (moneyScript.totalMoney >= minusByTotal)
        {
            moneyScript.minus = minusByTotal;
            moneyScript.decreaseMoney();
            coalMineLevel++;
            minusByTotal = 100 * coalMineLevel;
            azureMine.coalValue = coalMineLevel * 5;
            cost.text = "$" + minusByTotal.ToString();


        }
    }
}
