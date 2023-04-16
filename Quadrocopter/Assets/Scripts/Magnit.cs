using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Magnit : MonoBehaviour
{
    Transform connected;
    Vector3 offset;
    bool isPresed = false;

    private void Start()
    {
        isPresed = false;
    }
    private void Update()
    {
        if ((connected != null) && (isPresed = true))
        {
            connected.position = transform.position + offset;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isPresed)
        {
            connected = collision.transform;
            offset = connected.position - transform.position;
        }
        
    }
    public void OnPress()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isPresed = true;
        }
    }
    public void OnRelease()
    {
        if (Input.GetKeyUp(KeyCode.F))
        { 
            isPresed = false;
            connected = null;
        }
        
    }
}