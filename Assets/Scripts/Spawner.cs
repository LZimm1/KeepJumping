using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private Transform spawnerPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnEnemies(){
        while(true){
            yield return new WaitForSeconds(2);
            Instantiate(enemy);
            enemy.transform.position = spawnerPos.position;
            enemy.transform.position = new Vector3(enemy.transform.position.x,(float) Random.Range(-2,3),enemy.transform.position.z);
        }
    }
}
