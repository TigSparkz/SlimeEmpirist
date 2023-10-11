using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSlimes : MonoBehaviour
{
    public MoneyScript moneyScript;
    public RNGSpawner rngspawner;

    public GameObject slimeParent;


    // Start is called before the first frame update
    void Start()
    {
        slimeParent = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onPress()
    {
        moneyScript.add = 5000000000000;
        moneyScript.increaseMoney();
        rngspawner.totalSlimes--;
        Destroy(slimeParent);
    }
}
