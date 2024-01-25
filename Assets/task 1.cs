using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1 : MonoBehaviour
{

    //Emily Thorsen

    public float modules;
    public float reading;
    public float quizzes;
    public float assignments;
    public float instructor;
    private float output;

    // Start is called before the first frame update
    void Start()
    {
        //function goes here
        Calculation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Calculation()
    {
        //if course is 15 weeks long and has 1 module, 2 readings, 1 quiz, 1 assignment, and they taught it before, max value of things is 90
        Debug.Log("Task 1 calculation is run");

        //calculation
        output = (modules * .15f) + (reading * .3f) + (quizzes * .15f) + (assignments * .3f) + (instructor * .1f);

        //here's calc output
        Debug.Log("Task 1: " + output);
    }
}
