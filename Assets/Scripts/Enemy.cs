using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D mybody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove(5);
    }
    private void EnemyMove(float speed){
        mybody.velocity = new Vector2(speed,mybody.velocity.y); 
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Collector")){
            Destroy(gameObject);
        }
    }
}
