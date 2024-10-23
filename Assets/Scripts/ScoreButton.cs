using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;
    public Text scoreText;

    void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp); // 메소드를 연결할 때는 () 안붙임.
        RefreshUI();
    }

    void PointUp()
    {
        score++;
        Debug.Log("Score" + score);
        RefreshUI();
    }

    void RefreshUI()
    {
        scoreText.text = "Score: " + score;
    }
}
