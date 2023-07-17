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
      float speed = 5f;
      int spawnCount = 0;
      int enemyLevel = 0;
      int spawnCountTargetValue = 1;
      int disposableSpawnCount = 3;
      float HP = 1;
      while(true){
        disposableSpawnCount = 3;
        foreach (float posX in arrPosX) {
          if(Random.value >= 0.6 && disposableSpawnCount >= 0){
            SpawnEnemy(posX, speed, HP); 
            spawnCount ++;
            disposableSpawnCount --;
          }
        }
        yield return new WaitForSeconds(spawnInterval);
        
        if (spawnCount >= spawnCountTargetValue){
          spawnCountTargetValue *= 2;
          enemyLevel ++;
          speed += 0.5f;
          if(spawnInterval >= 1){
            spawnInterval -= 0.2f;
          } else if(spawnInterval > 0.1f){
            spawnInterval -= 0.1f;
          }
          HP ++;
          Debug.LogFormat("speed = {0} / spawnInterval = {1}",speed,spawnInterval);
        }
      }
    }
    void SpawnEnemy(float posX, float speed, float HP){
      Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
      GameObject enemyObject = Instantiate(this.enemy, spawnPos, Quaternion.identity);
      Enemy enemy = enemyObject.GetComponent<Enemy>();
      enemy.setSpeed(speed);
      enemy.setHP(HP);


    }
}
