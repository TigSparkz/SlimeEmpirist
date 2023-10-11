using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public Animator leave;
    private int cost;
    public MoneyScript moneyScript;
    public AzureMine azureMine;
    public AzureUpgrade azureUpgrade;
    private GameObject itself;

    // Start is called before the first frame update
    void Start()
    {
        cost = 500;
        itself = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPress()
    {
        if (cost <= moneyScript.totalMoney)
        {
            moneyScript.minus = cost;
            moneyScript.decreaseMoney();
            azureUpgrade.azureValueMultiplier = 2;
            azureMine.newWorth = azureMine.newWorth * 2;
            leave.Play("TopButtonUpgrade");
        }
    }
}
