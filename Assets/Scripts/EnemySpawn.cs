using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
  [SerializeField]
  private GameObject enemy;

  private float[] arrPosX = {-2.2f, -1.1f, 0f, 1.1f, 2.2f};
  private float spawnInterval = 5f;


    void Start()
    {
     startEnemyRoutine(); 
    }

    void startEnemyRoutine(){
      StartCoroutine("EnemyRoutine");
    }

    IEnumerator EnemyRoutine(){
      yield return new WaitForSeconds(1f);
      float speed = 1f;
      int spawnCount = 0;
      int enemyLevel = 0;
      int spawnCountTargetValue = 1;
      while(true){
        foreach (float posX in arrPosX) {
          SpawnEnemy(posX, speed); 
          spawnCount ++;
        }
        yield return new WaitForSeconds(spawnInterval);
        
        if (spawnCount >= spawnCountTargetValue){
          spawnCountTargetValue *= 2;
          enemyLevel ++;
          speed += 0.1f;
        }
      }
    }
    void SpawnEnemy(float posX, float speed){
      Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
      //if (Random.Range(0,5) == 0){}
      GameObject enemyObject = Instantiate(this.enemy, spawnPos, Quaternion.identity);
      Enemy enemy = enemyObject.GetComponent<Enemy>();
      enemy.setSpeed(speed);


    }
}
