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
    }
  }
}
