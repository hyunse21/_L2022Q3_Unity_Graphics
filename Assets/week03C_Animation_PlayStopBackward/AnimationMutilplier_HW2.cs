using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMutilplier_HW2 : MonoBehaviour
{
    Animator HW;
    // Start is called before the first frame update
    void Start()
    {
        HW = GetComponent<Animator>();
        HW.SetFloat("Direction", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            HW.SetFloat("Direction", 0f);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            HW.SetFloat("Direction", 1f);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            HW.SetFloat("Direction", -1f);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            HW.SetFloat("Direction", -3f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            HW.SetFloat("Direction", 4f);
        }
    }
}
