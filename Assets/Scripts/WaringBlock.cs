using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaringBlock : MonoBehaviour
{
    public static float speed = 5f;

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(0f, 0f, 180f * Time.deltaTime);
        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
}
