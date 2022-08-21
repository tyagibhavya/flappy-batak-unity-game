using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardController : MonoBehaviour
{
    public static ScoreBoardController instance;
    public Text scoreText;
    int score = 0;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void AddPoints()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
