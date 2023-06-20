using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XP : MonoBehaviour
{
  private float getXP = 1f;

  private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.name == "Player"){
      Destroy(gameObject);
      XPControll xpControll = GameObject.Find("XPControll").GetComponent<XPControll>();
      xpControll.xp += getXP;
      if(xpControll.xp >= xpControll.needxp){
        xpControll.xp -= xpControll.needxp;
        xpControll.level += 1;
        xpControll.needxp += 3;
      }
      Debug.LogFormat("{0}, {1}, {2}", xpControll.xp, xpControll.needxp, xpControll.level);
    }
  }
}
