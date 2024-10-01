using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score: MonoBehaviour
{
    public Text scoreText;
    private float score;

    public float pointsPerSecond = 10f;

    private bool isGameActive = true;

    void Update()
    {
        if (isGameActive)
        {

            score += pointsPerSecond * Time.deltaTime;

            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }


    public void StopScoring()
    {
        isGameActive = false;
    }

}
