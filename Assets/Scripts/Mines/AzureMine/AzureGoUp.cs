using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AzureGoUp : MonoBehaviour
{
    public Animator textUp;
    [SerializeField] private float waitTime;
    [SerializeField] private float timeSince;
    [SerializeField] private int isOver;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = 0.5f; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseOver()
    {
        isOver = 0;
        timeSince = 0;
        textUp.Play("Base Layer.AzureBarTextUp");

    }
    public void OnMouseExit()
    {
        isOver = 1;
        StartCoroutine(checkIfDone());
    }
    IEnumerator checkIfDone()
    {
        while (timeSince < waitTime && isOver == 1)
        {
            timeSince = timeSince + Time.deltaTime;
            yield return null;
        }
        if (timeSince > waitTime)
        {
            textUp.Play("Base Layer.AzureBarTextDown");
        }
    }

}
