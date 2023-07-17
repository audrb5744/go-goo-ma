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
      XPControll xpControll = GameObject.Find("XPControll").GetComponent<XPControll>();
      Player player = GameObject.Find("Player").GetComponent<Player>();
      Attack attack = GameObject.Find("Attack").GetComponent<Attack>();
      xpControll.xp += getXP;
      if(xpControll.xp >= xpControll.needxp){
        xpControll.xp -= xpControll.needxp;
        xpControll.level += 1;
        xpControll.needxp += 3;
        player.setAttackSpeed(player.attackSpeed - 0.05f);
        attack.setDamage(attack.damage + 1);

      }
      Debug.LogFormat("{0}, {1}, {2}", xpControll.xp, xpControll.needxp, xpControll.level);
    }
  }
}
