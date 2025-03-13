using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    float _distance = 6.7f;
    int _count = 2;
    int _index = 2;

    public GameObject[] grounds;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
            return;

        gameObject.transform.localPosition += new Vector3(-0.04f, 0, 0);
        _count = 2 + (int)(-gameObject.transform.localPosition.x / 6.7f);

        if (_index != _count)
        {
            grounds[(_index - 2) % 3].transform.localPosition = new Vector3(_distance * _count, -5, 0);
            _index = _count;
        }
    }
}
