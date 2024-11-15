using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshPro namespace

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Change to TextMeshProUGUI
    private float score = 0;

    void Update()
    {
        // Increase the score over time
        score += Time.deltaTime * 2;  // Adjust multiplier as needed
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
    }
}
