using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]private TMP_Text scoreText;
     [SerializeField]private TMP_Text highscoreText;
    public int score=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(ScoreUp),1,1);
         int highscore=PlayerPrefs.GetInt("highscore");
         highscoreText.text=highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ScoreUp()
    {
        
        score=score+1;
         PlayerPrefs.SetInt("score",score);
        scoreText.text=score.ToString();
        int highscore=PlayerPrefs.GetInt("highscore");
        if (score>highscore)
        {
            PlayerPrefs.SetInt("highscore",score);
             highscoreText.text=score.ToString();
        }
    }
}
