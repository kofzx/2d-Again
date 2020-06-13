using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumController : MonoBehaviour
{
    public float runSpeed = 40f;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter");
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 targetVelocity = new Vector2(-runSpeed * Time.fixedDeltaTime, rb.velocity.y);
        rb.velocity = targetVelocity;
    }
}
