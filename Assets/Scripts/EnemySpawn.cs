using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
  [SerializeField]
  private GameObject enemy;

  private float[] arrPosX = {-2.2f, -1.1f, 0f, 1.1f, 2.2f};
  private float spawnInterval = 2f;


    void Start()
    {
     startEnemyRoutine(); 
    }

    void startEnemyRoutine(){
      StartCoroutine("EnemyRoutine");
    }

    IEnumerator EnemyRoutine(){
      yield return new WaitForSeconds(1f);
      float enemySpeed = 5f;
      int spawnCount = 0;
      int enemyLevel = 0;
      float spawnCountTargetValue = 2f;
      int disposableSpawnCount = 3;
      int enemyHP = 1;
      while(true){
        disposableSpawnCount = 3;
        foreach (float posX in arrPosX) {
          if(Random.value >= 0.6 && disposableSpawnCount >= 0){
            SpawnEnemy(posX, enemySpeed, enemyHP); 
            spawnCount ++;
            disposableSpawnCount --;
          }
        }
        yield return new WaitForSeconds(spawnInterval);
        
        if (spawnCount >= spawnCountTargetValue){
          spawnCountTargetValue *= 2.5f;
          enemyLevel ++;
          enemySpeed += 0.5f;
          if(spawnInterval >= 1){
            spawnInterval -= 0.2f;
          } else if(spawnInterval > 0.1f){
            spawnInterval -= 0.1f;
          }
            Enemy.enemyMAXHP += 1;
            Enemy.enemySpeed += 0.5f;
        }
      }
    }
    void SpawnEnemy(float posX, float speed, int HP){
      Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
      GameObject enemyObject = Instantiate(this.enemy, spawnPos, Quaternion.identity);
      Enemy.enemyHP = Enemy.enemyMAXHP; 


    }
}
