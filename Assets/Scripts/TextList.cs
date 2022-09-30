using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextList : MonoBehaviour
{
    [Header("Text Variables")]

    // A list of meme text items
    public List<string> memeText;

    // A TextMesh Pro object in our scene
    public TMP_Text textMesh;

    
    [Header("Timing Variables")]
    public float secondsBetweenTicks = 2f;
    public float timer = 0f;
    public int ticks = 0;


    int frameCounter;
    int frameMax = 200;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        ////////////////////////
        //// LIST ITERATION ////
        ////////////////////////


        // Iterate through every item in the memeText list
        while (i < memeText.Count)
        {
            // Print the value of this item to the console
            Debug.Log(memeText[i]);

            // Set the TextMesh Pro's text to this item
            textMesh.text = memeText[i];

            // Increment the iterator
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ///////////////////////////
        //// TIME-BASED OPTION ////
        ///////////////////////////

        // Increase our timer by the amount of time in this last frame
        // In this way, timer become a counter, in seconds!
        timer += Time.deltaTime;

        // Check if timer has reached the reset time
        if (timer > secondsBetweenTicks)
        {
            // Reset timer to zero
            timer = 0f;
            
            // Increment ticks... could this be used to iterate through our list??
            ticks++;
        }
        

        ////////////////////////////
        //// INPUT-BASED OPTION ////
        ////////////////////////////

        // Input checks every frame to see if mouse or keyboard events have triggered
        // This checks to see if the Spacebar has been pressed, and enters the if statment
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Someone hit the space bar!");
        }
    }
}
