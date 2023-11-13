using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                       

public class Score : MonoBehaviour
{
    public int score;                                       // переменная для очков
    public int max_score;
    public Text scoreText;                                  // переменная для текста

    private void Awake()
    {
        if(!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score", 0);
        }
    }

    void Start()
    {
        score = 0;                              // при старте кол-во очков будет равнять 0 
        max_score = PlayerPrefs.GetInt("Score");
    }


    
    void Update()
    {
        scoreText.text = score.ToString();                  // это связь очков и текста
    }

    private void OnTriggerEnter2D(Collider2D collision)     // метод для прохода через объект
    {
        if (collision.tag == "Score")                      
        {
            score++;                                        //  прибавляется одно очко
            if (score > max_score)
            {
                max_score = score;
                PlayerPrefs.SetInt("Score", max_score);
            }
        }
    }
}
