using NUnit.Framework;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreManager _Scoremanager;
    public static GameManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int Level=0;
    void Start()
    {
        Instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if(_Scoremanager.score>=(Level+1)*20)
        {
            NextLevel();
        }
    }
    void NextLevel()
    {
        Level=Level+1;
    }
}
