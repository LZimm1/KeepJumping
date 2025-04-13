using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUBPlatform : MonoBehaviour
{

    public static float xPos= 0f;

    public static float yPos= 0f;
    public AudioSource collectJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            xPos = Random.Range(-8,8);
            yPos = Random.Range(-4,1);
            transform.position = new Vector3(xPos,yPos,0f);
            PlayerMovement.jumpReady += 1;
            collectJump.Play();
        }
    }
}
