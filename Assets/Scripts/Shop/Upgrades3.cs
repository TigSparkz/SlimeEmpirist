using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades3 : MonoBehaviour
{
    public Animator leave;
    private int cost;
    public MoneyScript moneyScript;
    public AzureCountdown AzureCountdown;
    // Start is called before the first frame update
    void Start()
    {
        cost = 1000;
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
            InvokeRepeating("constantlyPress", 0, 1);
            leave.Play("BottomButtonUpgrade");
        }
    }
    public void constantlyPress()
    {
        AzureCountdown.increaseBar();
    }

}
