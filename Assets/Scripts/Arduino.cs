using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;
using System.Collections;

public class Arduino : MonoBehaviour
{
    public int commPort = 0;

    private SerialPort serial = null;

    public string state;
    private int StateInt;

    public bool upPressed = false;
    public bool downPressed = false;
    public bool leftPressed = false;
    public bool rightPressed = false;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Attempting Serial: " + commPort);
        serial = new SerialPort("\\\\.\\COM" + commPort, 9600);
        serial.ReadTimeout = 50;
        serial.Open();
    }

    private void Update()
    {
        if (serial.BytesToRead > 3)
        {
            upPressed = false;
            downPressed = false;
            leftPressed = false;
            rightPressed = false;            

            foreach (string value in serial.ReadExisting().Split(';'))
            {
                if (value.Trim() != "")
                {
                    state = value.Trim();
                    StateInt = Convert.ToInt32(value.Trim());
                    upPressed = (StateInt & (1 << 4 - 1)) != 0;
                    downPressed = (StateInt & (1 << 3 - 1)) != 0;
                    leftPressed = (StateInt & (1 << 2 - 1)) != 0;
                    rightPressed = (StateInt & (1 << 1 - 1)) != 0;

                    if (upPressed)
                    {
                        Debug.Log("Up is pressed");
                    }
                }
            }

        }
    }

    // be sure to close the serial when the game ends.
    void OnDestroy()
    {
        Debug.Log("Exiting");
        serial.Close();
    }
}