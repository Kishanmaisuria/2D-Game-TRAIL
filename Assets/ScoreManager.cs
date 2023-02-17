using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public UnityEngine.UI.Text MyScore;
    int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        MyScore.text = Score.ToString() + "Points:";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
