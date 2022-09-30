using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    // Examples for class
    public float speed;
    public int wheels;
    public int children;
    public bool lightSwitchOn;

    public int frameCounter;
    public int frameMax;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
        Vector3 newPos = new Vector3(0f,0f,frameCounter*0.1f);
        // transform.position = newPos;
        // transform.rotation;
        // transform.scale;
        if (frameCounter>frameMax)
        {
            frameCounter = 0;
            // do something 
        }
    }
}
