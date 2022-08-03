using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GunPicker gunPickStatusScript;
    
    public VariableJoystick joystick;
    public float speed;
    public float turnSpeed;
    [SerializeField] GameObject LookAtObject;
    [SerializeField] Rigidbody player;
    [SerializeField] float boundPusherForcePower;
    public Animator anim;

   

    void FixedUpdate()
    {
        transform.LookAt(LookAtObject.transform);
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        JoyStickMovement(horizontal, vertical);
        
        
    }

    void JoyStickMovement(float horizontal, float vertical)
    {

        Vector3 addedPos = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
        transform.Translate(addedPos,Space.Self);
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

           }
        else
           {
                anim.SetBool("run", false);
           }
        
        
        }   
        
        
    }

