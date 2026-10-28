using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    void Start()
    {
        UpdateScore();
    }
    public void AddPoint()
    {

        score++;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "Zebrano:  " + score;
    }
}
