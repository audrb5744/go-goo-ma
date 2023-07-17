using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField]
    //private float moveSpeed;

    [SerializeField]
    private GameObject shotObject;

    public static int HP = 3;

    public static float loc_x;

    // [SerializeField]
    // private Transform shotLoc;

    public static float attackSpeed = 0.5f;

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
        loc_x = transform.position.x;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float toX = Mathf.Clamp(mousePos.x,-2.5f,2.5f);
        float toY = Mathf.Clamp(mousePos.y,-4.65f,4.65f);
        transform.position = new Vector3(toX, toY, 0f);

        shot();
    }

    void shot(){
      if(Time.time - lastAttack > attackSpeed){
        Instantiate(shotObject, transform.position, Quaternion.identity);
        lastAttack = Time.time;
      }
    }

    private void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.tag == "Enemy"){
        if(HP >= 0){
          Destroy(other.gameObject);
          HP -= 1;
          if(HP < 1)
            Destroy(gameObject);
            //StopCoroutine("EnemyRoutine");
            //StopCoroutine("spawnWaringBlockCoroutine");
        }
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if(HP == 2){
          spriteRenderer.color = new Color(1f, 0.65f, 0f);
        } else if(HP == 1){
          spriteRenderer.color = new Color(255f, 0f, 0f);
        }
      }
    }

    
}
