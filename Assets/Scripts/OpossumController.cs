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

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 targetVelocity = new Vector2(-1 * runSpeed * Time.fixedDeltaTime, rb.velocity.y);
        rb.velocity = targetVelocity;
    }
}
