using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public LevelManager manager;

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
            manager.DoRightScore();
            Reset();
        }
        else if (transform.position.x > 10)
        {
            //right player dropped the ball
            manager.DoLeftScore();
            Reset();
        }
    }

    public void Reset()
    {
        transform.position = Vector3.zero;
        rb.velocity = new Vector2(Random.Range(-1f, 1f) > 0 ? 5 : -5, Random.Range(-5f, 5f));
    }
}
