using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Magnit : MonoBehaviour
{

    public Rigidbody droneRB;
    Vector3 concectedOffset = new Vector3(0, -10, 0);

    private void Up()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        HingeJoint joint = other.GetComponent<HingeJoint>();

        if (other.GetComponent<HingeJoint>())
        {
            joint.connectedBody = droneRB;
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = concectedOffset;
        }
    }
}