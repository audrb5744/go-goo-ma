using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  [SerializeField]
  private GameObject xpObject;

  [SerializeField]
  public static float enemySpeed = 15;

  public static int enemyHP = 1;
  public static int enemyMAXHP = 1;

  // Update is called once per frame
  void Update()
  {
      transform.position += Vector3.down * enemySpeed * Time.deltaTime;
      if(transform.position.y < -7){
        Destroy(gameObject);
      }
  }

  private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.tag == "AttackObject"){
      if(gameObject.transform.position.y < 5.35){
        enemyHP -= Attack.damage;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (0.5 >= enemyHP / enemyMAXHP){
          spriteRenderer.color = new Color(1f, 0.65f, 0f);
        }
        else if (enemyHP == 1){
          spriteRenderer.color = new Color(255f, 0f, 0f);
        }
        if(enemyHP <= 0){
          Destroy(gameObject);
          Instantiate(xpObject, gameObject.transform.position, Quaternion.Euler(new Vector3(0,0,90)));
        }
      }
      Destroy(other.gameObject);
    }
  }
}
