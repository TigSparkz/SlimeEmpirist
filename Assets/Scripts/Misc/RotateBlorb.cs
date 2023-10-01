using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlorb : MonoBehaviour
{
    public float rotation;
    public GameObject blorb;

    void Start()
    {
        rotation = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
    }
    public void rotate()
    {
        blorb.transform.eulerAngles = new Vector3
            (
            blorb.transform.eulerAngles.x,
            blorb.transform.eulerAngles.y + rotation * 4,
            blorb.transform.eulerAngles.z
            );
        
    }
}
