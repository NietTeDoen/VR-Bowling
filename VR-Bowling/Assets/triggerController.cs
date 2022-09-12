using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerController : MonoBehaviour
{
    public VariableController variableController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            print("ball entered");
            if(VariableController.BallsLeft >= 1)
            {
                VariableController.BallsLeft -= 1;
                print("ball -1");
                variableController.BallSpawner();
            }
            else
            {
                print("going to score calculator");
                variableController.ScoreCalculator();
                variableController.BallSpawner();
            }
        }
    }
}
