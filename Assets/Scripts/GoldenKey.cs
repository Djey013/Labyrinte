using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKey : MonoBehaviour
{
    public float speedRotation = 0;

    void Update()
    {
        transform.Rotate(0, speedRotation, 0);
    }
}
