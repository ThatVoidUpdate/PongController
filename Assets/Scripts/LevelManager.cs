using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI LeftScoreText;
    public TextMeshProUGUI RightScoreText;
    private int LeftScore;
    private int RightScore;
    // Start is called before the first frame update
    void Start()
    {
        LeftScore = 0;
        RightScore = 0;
        LeftScoreText.text = LeftScore.ToString();
        RightScoreText.text = RightScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoLeftScore()
    {
        LeftScore++;
        LeftScoreText.text = LeftScore.ToString();
    }

    public void DoRightScore()
    {
        RightScore++;
        RightScoreText.text = RightScore.ToString();
    }
}
