using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRWalkingMovement : MonoBehaviour {
    public Transform vrCamera;
    public float toggleAngleBackward = 8.0f;
    public float toggleAngleForward = 352.0f;

    public float angle;

    public float speed = 3.0f;

    public bool moveForward;
    public bool moveBackward;

    private CharacterController controller;


    private bool InArc(float startAngle, float endAngle, float angle)
    {
        return startAngle <= angle && angle <= endAngle;
    }

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        angle = vrCamera.eulerAngles.z;

        /*if (vrCamera.eulerAngles.z >= toggleAngle && vrCamera.eulerAngles.z <= 90.0f)
            moveForward = true;
        else
            moveForward = false;
            */
        if (InArc(315.0f, toggleAngleForward, vrCamera.eulerAngles.z))
            moveForward = true;
        else
            moveForward = false;

        if (InArc(toggleAngleBackward, 45.0f, vrCamera.eulerAngles.z))
            moveBackward = true;
        else
            moveBackward = false;

        /*if (vrCamera.eulerAngles.z >= toggleAngleForward && vrCamera.eulerAngles.z <= 360.0f - 45.0f)
            moveForward = true;
        else
            moveForward = false;

        if (vrCamera.eulerAngles.z >= toggleAngleBackward && vrCamera.eulerAngles.z <= 45.0f)
            moveBackward = true;
        else
            moveBackward = false;
            */
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * speed);
        }

        if (moveBackward)
        {
            Vector3 backward = vrCamera.TransformDirection(Vector3.back);
            controller.SimpleMove(backward * speed); 
        }
	}
}
