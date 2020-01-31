using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public GameObject TrackingObject;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MoveDirection = TrackingObject.transform.position - transform.position;
        float Movement = (MoveDirection.normalized * Speed).y;
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + Movement, -3.9f, 3.9f), transform.position.z);
    }
}
