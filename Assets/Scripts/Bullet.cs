using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        pos.z += 0.5f;

        transform.position = pos;

        if(pos.z >= 20)
        {
            Destroy(gameObject);
        }
    }
}
