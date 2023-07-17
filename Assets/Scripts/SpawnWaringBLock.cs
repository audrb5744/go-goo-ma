using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaringBLock : MonoBehaviour
{
    [SerializeField]
    private int speed;

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

    IEnumerator spawnWaringBlockCoroutine()
    {
        yield return new WaitForSeconds(1f);
        while (true){
            Vector3 spawnPos = new Vector3(Player.loc_x, 6, 0);
            GameObject enemyObject = Instantiate(this.block, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(10f);
        }
        
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(0f, 0f, 180f * Time.deltaTime);
        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
}
