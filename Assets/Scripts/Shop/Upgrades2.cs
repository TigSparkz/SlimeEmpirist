using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades2 : MonoBehaviour
{
    public Animator leave;
    private int cost;
    public MoneyScript moneyScript; 
    public AzureMine azureMine;
    public AzureCountdown azureCountdown;
    private GameObject itself;
    // Start is called before the first frame update
    void Start()
    {
        cost = 250;
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
            azureCountdown.fillAmount = 0;
            azureCountdown.totalInc = 0.25f;
            azureMine.delayPress = 0.25f;
            azureCountdown.fillUpBy = 0.02f;
            leave.Play("MiddleButtomUpgrade");
        }
    }
}
