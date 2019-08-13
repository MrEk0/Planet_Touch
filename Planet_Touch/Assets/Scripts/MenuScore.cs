using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScore : MonoBehaviour
{
    Text scoreText;

    private void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    private void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }

    public void Default()
    {
        PlayerPrefs.DeleteKey("Score");
        scoreText.text = "0";
    }
}
