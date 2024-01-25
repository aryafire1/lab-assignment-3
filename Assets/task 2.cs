using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2 : MonoBehaviour
{

    public float bookAmount; //y
    public float bookPrice; //x

    private float beforeShipping;
    private float afterShipping;
    private float profit;

    // Start is called before the first frame update
    void Start()
    {
        Math();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Math()
    {
        //yippee yippee math!!!!!!!!
        Debug.Log("Task 2 calculation is run");

        //math stuff
        /*beforeShipping = (bookPrice * bookAmount) * 0.4f;
        afterShipping = ((beforeShipping - 3) - (0.75f * (bookAmount - 1)));
        profit = bookPrice * booksSold;*/

        //calculates price store buys book at
        beforeShipping = (bookPrice * bookAmount) * 0.4f;

        profit = (beforeShipping - 3) * ((bookAmount - 1) * 0.75f);

        //print
        Debug.Log("Task 2 before shipping: " + beforeShipping);
        Debug.Log("Task 2 profit: " + profit);




    }
}
