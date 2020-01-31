using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDRManager : MonoBehaviour
{
    public float DDRDelay;

    public float Score;
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

        yield return new WaitForSeconds(DDRDelay);
        StartCoroutine(SpawnDDR());
    }
}
