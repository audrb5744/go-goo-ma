using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaringBlock : MonoBehaviour
{
    [SerializeField]
    private float speed;

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
