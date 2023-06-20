using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField]
    //private float moveSpeed;

    [SerializeField]
    private GameObject shotObject;

    [SerializeField]
    private Transform shotLoc;

    [SerializeField]
    private float attackSpeed = 0.05f;
    private float lastAttack = 0f;
    void Update()
    {
        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // float verticalInput = Input.GetAxisRaw("Vertical");
        // Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f);
        // transform.position += moveTo * moveSpeed * Time.deltaTime;

        // Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        // if (Input.GetKey(KeyCode.LeftArrow)){
        //   transform.position -= moveTo;
        // } else if (Input.GetKey(KeyCode.RightArrow)) {
        //   transform.position += moveTo;
        // }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float toX = Mathf.Clamp(mousePos.x,-2.5f,2.5f);
        float toY = Mathf.Clamp(mousePos.y,-4.65f,4.65f);
        transform.position = new Vector3(toX, toY, 0f);

        shot();
    }

    void shot(){
      if(Time.time - lastAttack > attackSpeed){
        Instantiate(shotObject, shotLoc.position, Quaternion.identity);
        lastAttack = Time.time;
      }
    }

    
}
