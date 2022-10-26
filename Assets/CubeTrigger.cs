using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public GameObject targetObject;

    void OnTriggerStay(Collider other)
    {
        targetObject.transform.Rotate(new Vector3(10, 10, 10));
    }
}
