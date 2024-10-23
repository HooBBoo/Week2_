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
        scoreButton.onClick.AddListener(PointUp); // �޼ҵ带 ������ ���� () �Ⱥ���.
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
