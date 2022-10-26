using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource targetObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.Play(0);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.Pause();
    }
}
