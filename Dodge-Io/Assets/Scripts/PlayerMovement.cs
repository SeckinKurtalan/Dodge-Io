using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public VariableJoystick joystick;
    public float speed;
    public float turnSpeed;
    [SerializeField] GameObject LookAtObject;
    [SerializeField] Rigidbody player;
    [SerializeField] float boundPusherForcePower;
    public Animator anim;
    void FixedUpdate()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        JoyStickMovement(horizontal, vertical);

        //Debug.Log("horizontal " + joystick.Horizontal);
        //Debug.Log("vertical " + joystick.Vertical);

    }

    void JoyStickMovement(float horizontal, float vertical)
    {

        Vector3 addedPos = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
        transform.position += addedPos;
        if(transform.position.z < -98)
        {
            player.AddForce(Vector3.forward * boundPusherForcePower);
        }
        else if(transform.position.z > 98)
        {
            player.AddForce(Vector3.back * boundPusherForcePower);
        }
        else if (transform.position.x < -98)
        {
            player.AddForce(Vector3.right * boundPusherForcePower);
        }
        else if (transform.position.x > 98)
        {
            player.AddForce(Vector3.left * boundPusherForcePower);
        }
        else
        {
            player.velocity = Vector3.zero;
        }
        
        if (horizontal != 0 || vertical != 0)
        {
            anim.SetBool("run", true);
            //Vector3 direction = Vector3.forward * vertical + Vector3.right * horizontal;
            transform.LookAt(LookAtObject.transform);
        }
        else
        {
            anim.SetBool("run", false);
        }
    }
}
