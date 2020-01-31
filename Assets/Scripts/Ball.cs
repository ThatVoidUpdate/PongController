using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10)
        {
            //left player dropped the ball
        }
        else if (transform.position.x > 10)
        {
            //right player dropped the ball
        }
    }

    public void Reset()
    {
        transform.position = Vector3.zero;
        rb.velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
    }
}
