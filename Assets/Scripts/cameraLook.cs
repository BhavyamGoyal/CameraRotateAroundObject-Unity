using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLook : MonoBehaviour
{

    public Transform obj;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(obj);
    }
}
