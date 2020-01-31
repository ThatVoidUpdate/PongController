using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { Up, Down, Left, Right}
public class DDRArrow : MonoBehaviour
{
    public Direction direction;

    public float CorrectHitPosition;

    public float speed;

    public float DestroyPosition;

    private Arduino controller;
    private DDRManager manager;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("ArduinoManager").GetComponent<Arduino>();
        manager = GameObject.FindGameObjectWithTag("DDRManager").GetComponent<DDRManager>();
        print(gameObject.name + " " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position - new Vector3(0, speed, 0);
        if (transform.position.y < DestroyPosition)
        {
            Destroy(gameObject);
        }

        switch (direction)
        {
            case Direction.Up:
                if (controller.upPressed)
                {
                    float Distance = Mathf.Abs(CorrectHitPosition - transform.position.y);
                    manager.Score += 10 / Distance;
                    Destroy(gameObject);
                }
                break;
            case Direction.Down:
                if (controller.downPressed)
                {
                    float Distance = Mathf.Abs(CorrectHitPosition - transform.position.y);
                    manager.Score += 10 / Distance;
                    Destroy(gameObject);
                }
                break;
            case Direction.Left:
                if (controller.leftPressed)
                {
                    float Distance = Mathf.Abs(CorrectHitPosition - transform.position.y);
                    manager.Score += 10 / Distance;
                    Destroy(gameObject);
                }
                break;
            case Direction.Right:
                if (controller.rightPressed)
                {
                    float Distance = Mathf.Abs(CorrectHitPosition - transform.position.y);
                    manager.Score += 10 / Distance;
                    Destroy(gameObject);
                }
                break;
            default:
                break;
        }

    }
}
