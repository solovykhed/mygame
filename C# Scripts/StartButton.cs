using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public int score;
    public Text scoreText;

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = score.ToString();
    }
    public void StartScene()
    {
        SceneManager.LoadScene(1);
    }
}
