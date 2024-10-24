using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        scoreButton.OnScoreChanged += RefreshUI; // OnScoreChanged가 점수가 변경된 것 받아와서
                                                 // RefreshUI가 실행
    }
    void RefreshUI(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}