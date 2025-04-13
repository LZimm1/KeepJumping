using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveForce = 8f;

    public static bool countingScore = false;
    public static float score = 0f;
    private float movementX;

    private float jumpForce = 10f;

    public static int jumpReady = 1;

    private Vector3 tempPos;

    public static bool gameOver = false;

    public AudioSource jumpSound;
    [SerializeField]
    private Rigidbody2D mybody;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
        playerJump();
        if(transform.position.x < -8.4){
            tempPos = transform.position;
            tempPos.x = -8.4f;
            transform.position = tempPos;

        }
        if(transform.position.x > 8.4){
            tempPos = transform.position;
            tempPos.x = 8.4f;
            transform.position = tempPos;
        }
        if(countingScore){
            score+=Time.deltaTime;
        }
        if(gameOver){
            countingScore=false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Platform")){
            jumpReady += 1;
        }
        else if(collision.gameObject.CompareTag("Obstacle")){
            gameOver = true;
            
        }
    }
    void playerMove(){
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }
    void playerJump(){
        if(Input.GetButtonDown("Jump") && jumpReady >= 1){
            mybody.velocity = new Vector3(0f,0f,0f);
            mybody.AddForce(new Vector2(0f,jumpForce), ForceMode2D.Impulse);
            jumpReady -= 1;
            jumpSound.Play();
        }
    }
}
