using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task3 : MonoBehaviour
{

    public int bills;

    private float hundred;
    private float fifty;
    private float twenty;
    private float ten;
    private float five;
    private float one;

    // Start is called before the first frame update
    void Start()
    {
        Wowza();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Wowza()
    {
        //my brain hurts
         Debug.Log("Task 3 calculation is run");

        // holy moly this went up in smoke
        //hundreds
        hundred = bills/100;
        if (hundred > 0)
        {
            int count = bills / 100;
            if (count > 0)
            {
                bills -= count * 100;
                Debug.Log(hundred + "hundreds");
            }
        }

        //fifty
        fifty = bills / 50;
        if (fifty > 0)
        {
            int count = bills / 50;
            if (count > 0)
            {
                bills -= count * 50;
                Debug.Log(fifty + "Fifty");
            }
        }
        //twenty
        twenty = bills / 20;
        if (twenty > 0)
        {
            int count = bills / 20;
            if (count > 0)
            {
                bills -= count * 20;
                Debug.Log(twenty + "twenty");
            }
        }



        //ten
        ten = bills / 10;
        if (ten > 0)
        {
            int count = bills / 10;
            if (count > 0)
            {
                bills -= count * 10;
                Debug.Log(ten + "ten");
            }
        }


        //five
        five = bills / 5;
        if (five > 0)
        {
            int count = bills / 5;
            if (count > 0)
            {
                bills -= count * 5;
                Debug.Log(five + "five");
            }
        }


        //one
        one = bills / 1;
        if (one > 0)
        {
            int count = bills / 1;
            if (count > 0)
            {
                bills -= count * 1;
                Debug.Log(one + "one");
            }
        }


    }
}
