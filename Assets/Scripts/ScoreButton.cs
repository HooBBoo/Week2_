using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using System.Xml.Serialization;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;
    public Text scoreText;
    public Action<int> OnScoreChanged;

    void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp); // �޼ҵ带 ������ ���� () �Ⱥ���.
    }

    void PointUp()
    {
        score += 1;
        Debug.Log("Score" + score);
        OnScoreChanged?.Invoke(score);
        RefreshUI();
    }

    void RefreshUI()
    {
        scoreText.text = "Score: " + score;
    }
}
