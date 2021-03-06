using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject player;
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
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().Damage();
            player.GetComponent<PlayerMove>().TakeScore();
            Destroy(gameObject);
        }
    }
}
