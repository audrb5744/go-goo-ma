using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Restart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            if(Player.HP <= 0){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                XPControll.xp = 0f;
                XPControll.needxp = 3f;
                XPControll.level = 1;
                Attack.damage = 1;
                Player.attackSpeed = 0.5f;
                Enemy.kills = 0;
                Enemy.enemyMaxHP = 1;
                Player.HP = 3;
                Enemy.enemySpeed = 5f;
                WaringBlock.speed = 5f;
            }


            


        }
    }

    


}
