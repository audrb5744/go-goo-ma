using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  [SerializeField]
  private GameObject xpObject;

  [SerializeField]
  private float speed;

  private float HP = 1f;

  public void setSpeed(float speed){
    this.speed = speed;
  }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if(transform.position.y < -7){
          Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "AttackObject"){
        Attack attack = other.gameObject.GetComponent<Attack>();
        if(gameObject.transform.position.y < 5.35){
          HP -= attack.damage; 
          if(HP <= 0){
            Destroy(gameObject);
            Instantiate(xpObject, gameObject.transform.position, Quaternion.Euler(new Vector3(0,0,90)));
          }
        }
        Destroy(other.gameObject);
      }
    }
}
