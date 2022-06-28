using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 1;
    public float time = 2;
    protected Vector3 forward = new Vector3 (0, 0, 1);
    protected Quaternion forwardAxis = Quaternion.identity;
    protected Rigidbody rb;
    protected GameObject enemy;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(enemy != null)
        {
            forward = enemy.transform.forward;
        }
    }
    void FixedUpdate()
    {
        rb.velocity = forwardAxis * forward * speed;
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        time -= Time.deltaTime;

        if(time <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void SetCharacterObject(GameObject character)
    {
        this.enemy = character;
    }
    public void SetForwardAxis(Quaternion axis)
    {
        this.forwardAxis = axis; 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "PlayerBody")
        {
            Destroy(gameObject);
        }
    }
}