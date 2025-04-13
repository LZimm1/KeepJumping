using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class JumpCount : MonoBehaviour
{
    public Text scoreText;
    public Text scoreText2;
    public Text highScore;
    private static int highScoreNum = 0;
    private int intScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        intScore = (int) (100 *PlayerMovement.score);
        
        if(scoreText){
            scoreText.text = PlayerMovement.jumpReady.ToString();
        }
        if(SceneManager.GetActiveScene().name == "Game"){
            if(scoreText2){
                scoreText2.text= intScore.ToString();
            }
        }
        if(SceneManager.GetActiveScene().name == "GameOverScreen" && intScore != 0){ 
            if(scoreText2){
                scoreText2.text = intScore.ToString();
            }
            if(highScore){
                if(intScore > highScoreNum){
                    highScoreNum = intScore;
                }  
                highScore.text = highScoreNum.ToString(); 
            }
             
        }
    }
}
