using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2 : MonoBehaviour
{
    Animator HW;
    // Start is called before the first frame update
    void Start()
    {
        HW = GetComponent<Animator>();
        HW.speed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            HW.speed = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            HW.speed = 0.0f;
        }

    }
}
