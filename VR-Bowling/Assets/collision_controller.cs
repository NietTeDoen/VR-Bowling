using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_controller : MonoBehaviour
{
    public bool Hit;
    public VariableController variableController;

    // Start is called before the first frame update
    void Start()
    {
        Hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground" && !Hit)
        {
            Hit = true;
            VariableController.tempScore += 1;
            print(VariableController.tempScore);
        }
    }
}
