using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipebreaker : MonoBehaviour
{
    float makeTime;

    // Start is called before the first frame update
    void Start()
    {
        makeTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - makeTime > 6f)
            Destroy(gameObject);

    }
}
