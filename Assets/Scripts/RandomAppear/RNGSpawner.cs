using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class RNGSpawner : MonoBehaviour
{
    public GameStart gameStart;
    public Transform AzureSlimeEmpty;

    public int totalSlimes = 0;
    public GameObject slime;
    private int RNGNumber;
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart.startInstantiate == 1)
        {
            InvokeRepeating("RNGCalculator",1f,1f);
            enabled = false;
        }
    }


    public void RNGCalculator()
    {
        print("Here2");
        RNGNumber = Random.Range(0,10);
        if (RNGNumber > 4 && totalSlimes < 3)
        {
            SpawnSlimes();
        }
    }
    public void SpawnSlimes()
    {
        print("Here3");
        float spawnY = Random.Range
            (mainCamera.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (mainCamera.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
        

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Transform spawnedSlime = Instantiate(AzureSlimeEmpty, spawnPosition, Quaternion.identity) as Transform;
        spawnedSlime.transform.SetParent(AzureSlimeEmpty, true);
        spawnedSlime.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
        totalSlimes++;  

    }
}
