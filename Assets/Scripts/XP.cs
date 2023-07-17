using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XP : MonoBehaviour
{
  private float getXP = 1f;

  void Update()
    {
      if(transform.position.y < -7){
        Destroy(gameObject);
      }
    }

  private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.name == "Player"){
      Destroy(gameObject);
      XPControll.xp += getXP;
      if(XPControll.xp >= XPControll.needxp){
        XPControll.xp -= XPControll.needxp;
        XPControll.level += 1;
        XPControll.needxp += 3;
        Player.attackSpeed -= 0.05f;
        Attack.damage += 1;

      }
    }
  }
}
