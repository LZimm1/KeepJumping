using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else{
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.gameOver){
            SceneManager.LoadScene("GameOverScreen");
            PlayerMovement.gameOver = false;
        }
        if(ButtonScript.newGame == true){
            LoadNewGame();
            ButtonScript.newGame = false;
        }
        if(SceneManager.GetActiveScene().name == "Game"){
            Cursor.visible = false;
        }
        if(SceneManager.GetActiveScene().name == "GameOverScreen"){
            Cursor.visible = true;
        }
    }
    void LoadNewGame(){
        SceneManager.LoadScene("Game");
        PlayerMovement.score = 0;
        PlayerMovement.jumpReady = 1;
        PlayerMovement.countingScore = false;
    }
}

