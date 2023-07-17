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
      float spawnCountTargetValue = 2f;
      int disposableSpawnCount = 3;
      int enemyLevel = 1;
      int spawnAllLine = 0;
      int CountingSpawn = 0;
      while(true){
        disposableSpawnCount = 3;
        if(CountingSpawn >= 100){
          CountingSpawn -= 100;
          spawnAllLine += 1;
        }
        
        if(spawnAllLine > 0){
            foreach (float posX in arrPosX){
                SpawnEnemy(posX, enemySpeed, Enemy.enemyMaxHP * 2);
                spawnCount++;
                CountingSpawn ++;
            }
            spawnAllLine--;
        } else {
            foreach (float posX in arrPosX) {
              if(Random.value >= 0.6 && disposableSpawnCount >= 0){
                SpawnEnemy(posX, enemySpeed, Enemy.enemyMaxHP); 
                spawnCount ++;
                CountingSpawn ++;
                disposableSpawnCount --;
              }
          }
        }
        yield return new WaitForSeconds(spawnInterval);
        
        if (spawnCount >= spawnCountTargetValue){
          spawnCountTargetValue *= 2.5f;
          enemySpeed += 0.5f;
          enemyLevel += 1;
          if(spawnInterval >= 1){
            spawnInterval -= 0.2f;
          } else if(spawnInterval > 0.1f){
            spawnInterval -= 0.1f;
          }
            if(enemyLevel > 2){
              Enemy.enemyMaxHP += 1;
            }
            Enemy.enemySpeed += 0.5f;
        }
      }
    }
    void SpawnEnemy(float posX, float speed, int HP){
      Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
      GameObject enemyObject = Instantiate(this.enemy, spawnPos, Quaternion.identity);
      Enemy.enemyHP = HP;


    }
}
