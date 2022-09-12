using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableController : MonoBehaviour
{
    public static float Score = 0;
    public static float tempScore = 0;
    public static bool doubled;
    public GameObject ScoreTXT;
    public GameObject ThrowsLeft;
    public GameObject PinsOver;
    public static int BallsLeft = 1;
    public GameObject PinCollectorPrefab;
    public GameObject PinCollector;
    public Rigidbody PinLocation;
    private Vector3 PL3;
    public GameObject BallSpawnLocation;
    public GameObject BallPrefab;
    // Start is called before the first frame update
    void Start()
    {
        PL3 = PinLocation.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TextMesh Text = ScoreTXT.GetComponent<TextMesh>();
        TextMesh pinsFall = PinsOver.GetComponent<TextMesh>();
        TextMesh throwsleft = ThrowsLeft.GetComponent<TextMesh>();
        Text.text = "Score: " + Score;
        pinsFall.text = "Pins Fallen: " + tempScore;
        throwsleft.text = "Throws left: " + BallsLeft;

    }

    public void ScoreCalculator()
    {
        if (tempScore == 10 && !doubled)
        {
            doubled = true;
            if (doubled)
            {
                Score = tempScore * 2 + Score;
                tempScore = 0;
                print("your real score is: " + Score);
                BallsLeft = 1;
                Destroy(PinCollector);
                PinCollector = Instantiate(PinCollectorPrefab);
            }
        }
        else
        {
            
            Score = Score + tempScore;
            tempScore = 0;
            print("your real score is: " + Score);
            BallsLeft = 1;
            Destroy(PinCollector);
            PinCollector = Instantiate(PinCollectorPrefab, PinLocation.transform, false);
        }
    }
    public void BallSpawner()
    {
        GameObject ball = Instantiate(BallPrefab, BallSpawnLocation.transform, false);
    }
}
