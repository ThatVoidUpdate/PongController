using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDRManager : MonoBehaviour
{
    public float DDRDelay;

    public float Score;
    public Canvas canvas;

    [Space]
    public GameObject UpArrow;
    public GameObject DownArrow;
    public GameObject LeftArrow;
    public GameObject RightArrow;
    [Space]
    public Vector2 UpArrowPosition;
    public Vector2 DownArrowPosition;
    public Vector2 LeftArrowPosition;
    public Vector2 RightArrowPosition;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDDR());
    }

    // Update is called once per frame
    void Update()
    {
        Score -= Score > 0 ? 0.05f : 0;
    }

    IEnumerator SpawnDDR()
    {
        if (Random.Range(-1f, 1f) > 0 && !GameObject.FindGameObjectWithTag("Up"))
        {
            Instantiate(UpArrow, canvas.transform).transform.position = UpArrowPosition;
        }
        if (Random.Range(-1f, 1f) > 0 && !GameObject.FindGameObjectWithTag("Down"))
        {
            Instantiate(DownArrow, canvas.transform).transform.position = DownArrowPosition;
        }
        if (Random.Range(-1f, 1f) > 0 && !GameObject.FindGameObjectWithTag("Left"))
        {
            Instantiate(LeftArrow, canvas.transform).transform.position = LeftArrowPosition;
        }
        if (Random.Range(-1f, 1f) > 0 && !GameObject.FindGameObjectWithTag("Right"))
        {
            Instantiate(RightArrow, canvas.transform).transform.position = RightArrowPosition;
        }
        yield return new WaitForSeconds(DDRDelay);
        StartCoroutine(SpawnDDR());
    }
}
