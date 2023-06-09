using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    Movement movementScript;
    bool onGround, onGroundLastFrame;
    void Awake()
    {
        movementScript = GetComponentInParent<Movement>();
    }

    void Update()
    {
        if (onGround != onGroundLastFrame)
        {
            //movementScript.onGround = onGround;
        }
        onGroundLastFrame = onGround;
    }

    private void FixedUpdate()
    {
        onGround = false;
    }

    /*private void OnTriggerStay(Collider other)
    {
        onGround = true;
    }*/

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.position.y > transform.position.y || collision.transform.position.y < transform.position.y)
        {
            onGround = true;
        }
        //onGround = true;
    }
}
