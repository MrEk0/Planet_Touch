using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    Text score;
    int touchScore = 0;

    private void Awake()
    {
        score = GetComponent<Text>();
    }

    public void ChangeScore()
    {
        touchScore += 1;
        score.text = touchScore.ToString();
        if(touchScore>PlayerPrefs.GetInt("Score",0))
        PlayerPrefs.SetInt("Score", touchScore);
    }
}
