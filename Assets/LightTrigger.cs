using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public Light targetObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.enabled = false;
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.enabled = true;
    }
}
