using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotator : MonoBehaviour
{
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    }
}
