using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector2 Margin;
    public Vector2 smoothing;

    public bool IsFollowing { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        IsFollowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        var x = transform.position.x;
        var y = transform.position.y;
        if (IsFollowing)
        {
            if (Mathf.Abs(x - player.transform.position.x) > Margin.x)
            {
                x = Mathf.Lerp(x, player.transform.position.x, smoothing.x * Time.deltaTime);
            }
            if (Mathf.Abs(y - player.transform.position.y) > Margin.y)
            {
                y = Mathf.Lerp(y, player.transform.position.y, smoothing.y * Time.deltaTime);
            }
        }
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
