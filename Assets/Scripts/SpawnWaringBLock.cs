using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaringBLock : MonoBehaviour
{

    [SerializeField]
    private GameObject block;

    void Start()
    {
        startWaringRoutine();
    }

    void startWaringRoutine()
    {
        StartCoroutine("spawnWaringBlockCoroutine");
    }

    public IEnumerator spawnWaringBlockCoroutine()
    {
        yield return new WaitForSeconds(1f);
        while (true){
            Vector3 spawnPos = new Vector3(Player.loc_x, 6, 0);
            GameObject enemyObject = Instantiate(this.block, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(10f);
        }
        
    }

}
