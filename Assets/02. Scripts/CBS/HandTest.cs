using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTest : MonoBehaviour
{

    Vector3 prePos;
    // Start is called before the first frame update
    void Start()
    {
        prePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
    }
}
