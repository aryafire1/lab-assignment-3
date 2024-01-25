using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task3 : MonoBehaviour
{

    public float bills;

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
        hundred = bills % 100;
        if (hundred > 0)
        {
            hundred = bills - (hundred * 100);
            Debug.Log(hundred + "hundreds");
            fifty = hundred;
        }

        //fifty
        fifty = hundred % 50;
        if (fifty > 0)
        {
             hundred = hundred - (fifty * 50);
            Debug.Log(fifty + "fifties");
        }

        //twenty
         twenty = fifty % 20;
        if (twenty > 0)
        {
                        fifty = fifty - (twenty * 20);

            Debug.Log(twenty + "twenties");
        }

        //ten
         ten = twenty % 10;
        if (ten > 0)
        {
                        twenty = twenty - (ten * 10);

            Debug.Log(ten + "tens");
        }

        //five
         five = ten % 5;
        if (hundred > 0)
        {
                        ten = ten - (five * 5);

            Debug.Log(five + "fives");
        }

        //one
         one = five % 1;
        if (one > 0)
        {
                        five = five - (one);

            Debug.Log(one + "ones");
        }

    }
}
