using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
  [SerializeField]
  private float speed = 15f;
  public static int damage = 1;

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

        if(transform.position.y > 7){
          Destroy(gameObject);
        }
    }
}
