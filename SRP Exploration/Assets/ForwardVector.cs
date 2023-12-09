using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardVector : MonoBehaviour
{
    Vector3 _forward;

    // Start is called before the first frame update
    void Start()
    {
        _forward = new Vector3(0.0f, 0.0f, 1.0f);
    }

    Vector3 getForwardVector()
    {
        return _forward;
    }

    // Enforce that the forward is always a normal vector
    void setForwardVector(Vector3 newForward)
    {
        _forward = newForward.normalized;
    }
}
