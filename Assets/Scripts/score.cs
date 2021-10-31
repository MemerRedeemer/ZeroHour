using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text permanentScore;
    [SerializeField]
    private GameObject scoreTextActive;
    [SerializeField]
    private GameObject endScore;

    [SerializeField]
    private int scoreNumber = 0;

    void Start() {
        scoreText.text = "Score: " + 0;    
    }

    public void AddScore() {
        scoreNumber += 1;
        scoreText.text = "Score: " + scoreNumber.ToString();
    }

    public void Death(bool death) {
        if(death) {
            scoreTextActive.SetActive(false);
            endScore.SetActive(true);
            permanentScore.text = scoreText.text;
            Time.timeScale = 0;
        }
    }
}
