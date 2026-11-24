using UnityEngine;
using TMPro;
public class VerlorenManager : MonoBehaviour
{
     [SerializeField]private TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      scoreText.text=PlayerPrefs.GetInt("score").ToString();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
