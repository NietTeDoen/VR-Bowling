using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableController : MonoBehaviour
{
    public static float Score = 0;
    public GameObject ScoreTXT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TextMesh Text = ScoreTXT.GetComponent<TextMesh>();
        Text.text = "Score: " + Score;
    }
}
